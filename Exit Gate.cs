using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Guest_Entry_Recording_System
{
    public partial class Exit_Gate : Form
    {
        private readonly federal1Entities4 _db;
        ToolTip ToolTip1 = new ToolTip();
        public Exit_Gate()
        {
            InitializeComponent();
            GuestsPedUc n = new GuestsPedUc();
            _db = new federal1Entities4();
            n.GuestpopulateGrid();
        }

        void addusrtControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPn.Controls.Clear();
            MainPn.Controls.Add(userControl);
            MainPn.BringToFront();
            userControl.BringToFront();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {

                DialogResult dialogResult = MessageBox.Show("እርግጠኛ ኖት መዝጋት ይፈልጋሉ?", "ዝጋ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                GuestsCarUc gcu = new GuestsCarUc();
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

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                DialogResult dialogResult = MessageBox.Show("እርግጠኛ ኖት መውጣት ይፈልጋሉ?", "ውጣ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginAs la = new LoginAs();
                    this.Close();
                    la.Show();
                }
            }
        }

        private void Dashbtn_Click(object sender, EventArgs e)
        {
            DashExitUc dcu = new DashExitUc();
            addusrtControl(dcu);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "ዳሽቦርድ";
            }
            else WelcomeLb.Text = "Dashboard";
        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            GuestsCarUc gcu = new GuestsCarUc();
            addusrtControl(gcu);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "ባለ መኪና እንግዳዎች";
            }
            else WelcomeLb.Text = "car Guests";

            gcu.GuestInfoTlp.Hide();
            gcu.GunInfoTlp.Hide();
            gcu.btnCarInsert.Hide();
            gcu.btnCarClear.Hide();
            gcu.AddToBtn.Hide();
            gcu.InsertBtn.Hide();
            gcu.updatebtn.Hide();
            gcu.ClearBtn.Hide();
        }

        private void PedestrianBtn_Click(object sender, EventArgs e)
        {
            GuestsPedUc gpu = new GuestsPedUc();
            addusrtControl(gpu);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                WelcomeLb.Text = "እግረኛ እንግዳዎች";
            }
            else WelcomeLb.Text = "Pedestrian Guests";

            //gpu.GuestInfoTlp.Hide();
            gpu.GunInfoTlp.Hide();
            gpu.StartBtn.Hide();
            gpu.StopBtn.Hide();
            gpu.CameraLb.Hide();
            gpu.cboDevice.Hide();
            gpu.QrScannerPb.Hide();
           // gpu.insertbtn.Hide();
           // gpu.clearbtn.Hide();
            gpu.btInsertGun.Hide();
            //gpu.updatebtn.Hide();
            gpu.ClearBtn2.Hide();
            //gpu.AddToBtn.Hide();
        }

        private void InternsBtn_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Gate_Load(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                Dashbtn.Text = "ዳሽቦርድ";
                CarBtn.Text = "ባለ መኪና እንግዳዎች";
                PedestrianBtn.Text = "እግረኛ እንግዳዎች";
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

        private void MaxBtn_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.MaxBtn, "አተልቅ");
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

        private void MinBtn_MouseHover(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                ToolTip1.SetToolTip(this.MinBtn, "ደብቅ");
            }
            else ToolTip1.SetToolTip(this.MinBtn, "Minimize");
        }

        private int ClickCounter = 0;
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

        private void DarkLightBtn_Click(object sender, EventArgs e)
        {
            GuestsCarUc gcu = new GuestsCarUc();
            GuestsPedUc gpu = new GuestsPedUc();
            if (ClickCounter == 0)
            {
                DarkLightBtn.Image = Properties.Resources.LightMode;
                MainPn.BackColor = Color.FromArgb(25, 39, 52);
                gcu.GuestInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                gcu.GunInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                gpu.GuestInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                gpu.GunInfoTp.BackColor = Color.FromArgb(25, 39, 52);
                gpu.InternsTp.BackColor = Color.FromArgb(25, 39, 52);
                gpu.WETp.BackColor = Color.FromArgb(25, 39, 52);
                ClickCounter++;
            }
            else if (ClickCounter == 1)
            {
                DarkLightBtn.Image = Properties.Resources.darkmode;
                MainPn.BackColor = Color.FromArgb(215, 228, 242);
                gcu.GuestInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                gcu.GunInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                gpu.GuestInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                gpu.GunInfoTp.BackColor = Color.FromArgb(215, 228, 242);
                gpu.InternsTp.BackColor = Color.FromArgb(215, 228, 242);
                gpu.WETp.BackColor = Color.FromArgb(215, 228, 242);
                ClickCounter--;
            }
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
    }
}
