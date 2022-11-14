﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Guest_Entry_Recording_System
{
    public partial class Car_Recipient : Form
    {
        private LoginAs _login;
        public string _user;
        public int _userId;
        private readonly federal1Entities4 _db;
        public Car_Recipient()
        {
            InitializeComponent();
            _db = new federal1Entities4();
        }

        ToolTip ToolTip1 = new ToolTip();
        public Car_Recipient(LoginAs login, string username, int id)
        {
            InitializeComponent();
            _db = new federal1Entities4();
            _login = login;
            _user = username;
            _userId = id;
            UsernameLb.Text = _user;
            // do to retrive img//
            // var profile = _db.EMPLOYEEs.Where(b => b.fname == _user).Select(q => q.profile_pic).ToString();
            //var profile = _db.GUNs.Where(q => q.gun_id == 1005.).FirstOrDefault(q => q.gun_pic ==  );
            // var images = from p in _db.GUNs
            // select Image.FromStream(new MemoryStream(p.gun_pic));
            //int id = 3;


            //IQueryable<Image> image = from p in _db.EMPLOYEEs where p.emp_id == id select Image.FromStream(new MemoryStream(p.profile_pic.ToArray()));
            //var img = getphoto(Convert.ToInt32(_userId));
            //pbProfile.Image = img;

            //
            //
            //
            //

        }
        //public Image getphoto(int id)
        //{

        //    {
        //        var imgMetadata = _db
        //                .federal1Entities
        //                .FirstOrDefault(p => p.emp_id == id);

        //        //handle the case when image does not exist.


        //        //read the image bytes into an Image object.
        //        var img = Image.FromStream(new MemoryStream(imgMetadata.profile_pic.ToArray()));

        //        return img;

        //    }
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= 0x00020000;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoginAs la = new LoginAs();
                this.Close();
                la.Show();
            }

        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MaxBtn.Text = "< >";

                MaxBtn.Font = new Font("Arial", 8, FontStyle.Bold);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.Text = "[  ]";
            }
        }
        private void MaxBtn_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.MaxBtn,"አተልቅ");
                }
                else ToolTip1.SetToolTip(this.MaxBtn, "Maximize");
            }
            else
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.MaxBtn, "አሳንስ");
                }
                else ToolTip1.SetToolTip(this.MaxBtn, "Restore Down");
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinBtn_MouseHover(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                ToolTip1.SetToolTip(this.MinBtn, "ደብቅ");
            }
            else ToolTip1.SetToolTip(this.MinBtn, "Minimize");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                ToolTip1.SetToolTip(this.CloseBtn, "ዝጋ");
            }
            else ToolTip1.SetToolTip(this.CloseBtn, "Close");

        }

        private bool drag = false;
        Point start_point = new Point(0, 0);
        private void TopPn_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void TopPn_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void TopPn_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void TopPn_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MaxBtn.Text = "< >";
                MaxBtn.Font = new Font("Arial", 8, FontStyle.Bold);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.Text = "[  ]";
            }
        }

        void addusrtControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPn.Controls.Clear();
            MainPn.Controls.Add(userControl);
            MainPn.BringToFront();
            userControl.BringToFront();

        }

        private void Dashbtn_Click(object sender, EventArgs e)
        {
            DashCarUc dcu = new DashCarUc(_user, _userId);
            addusrtControl(dcu);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "ዳሽቦርድ";
            }
            else WelcomeLb.Text = "Dashboard";
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            GuestsCarUc gcu = new GuestsCarUc(this, _userId);
            addusrtControl(gcu);
            //gcu.ExitBtn.Hide();
            gcu.AddToBtn.Hide();
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "እንግዳዎች";
            }
            else WelcomeLb.Text = "Guests";
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            //ReportsUcCars ruc = new ReportsUcCars();
            //addusrtControl(ruc);
            //if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            //{
            //    WelcomeLb.Text = "ሪፖርት";
            //}
            //else WelcomeLb.Text = "Reports";
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsUcCars suc = new SettingsUcCars();
            addusrtControl(suc);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "ቅንብሮች";
            }
            else WelcomeLb.Text = "Settings";
        }


        private int ClickCounter = 0;
        private void DarkLightBtn_Click(object sender, EventArgs e)
        {
            GuestsCarUc gcu = new GuestsCarUc();
            if (ClickCounter == 0)
            {
                DarkLightBtn.Image = Properties.Resources.LightMode;
                MainPn.BaseColor = Color.FromArgb(25, 39, 52);
                gcu.GuestInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                gcu.GunInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                ClickCounter++;
            }
            else if (ClickCounter == 1)
            {
                DarkLightBtn.Image = Properties.Resources.darkmode;
                MainPn.BaseColor = Color.FromArgb(215, 228, 242);
                gcu.GuestInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                gcu.GunInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                ClickCounter--;
            }
        }

        private void DarkLightBtn_MouseHover(object sender, EventArgs e)
        {
            if (ClickCounter == 0)
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.DarkLightBtn, "ጠቆር ያለ ገጽታ");
                }
                else ToolTip1.SetToolTip(this.DarkLightBtn, "Dark Mode");
            }
            else
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.DarkLightBtn, "ነጣ ያለ ገጽታ");
                }
                else ToolTip1.SetToolTip(this.DarkLightBtn, "Light Mode");
            }
        }

        private void Car_Recipient_Load(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                Dashbtn.Text = "ዳሽቦርድ";
                GuestBtn.Text = "እንግዳዎች";
                ReportsBtn.Text = "ሪፖርት";
                SettingsBtn.Text = "ቅንብሮች";
            }
        }
    }
}