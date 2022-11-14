using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Globalization;

namespace Guest_Entry_Recording_System
{
    //NEW NEW 
    public partial class LoginAs : Form
    {
        private readonly federal1Entities4 _db;
        public LoginAs()
        {
            InitializeComponent();
            _db = new federal1Entities4();
           

        }
        ToolTip ToolTip1 = new ToolTip();
        public string hash(string password)
        {
            SHA256 sha = SHA256.Create();
            // covert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //create a new stringbuilder to collect the bytes
            //and create a string.
            StringBuilder sBuilder = new StringBuilder();

            //Loop through each byte of hashed data
            //and format each one as hexadesimal string

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            var Hashed_password = sBuilder.ToString();
            return Hashed_password;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                var username = UsernameTb.Text.Trim();
                var password = PasswordTb.Text;
                var hashed_password = password;
                var user = _db.recipents.FirstOrDefault(q => q.fname == username && q.password == hashed_password);

                if (user == null || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please provide valid information");
                }

                else

                {
                    var id = _db.recipents.FirstOrDefault(q => q.id == user.id);
                    var userId = Convert.ToInt16(user.id_number);
                    if (UserLb.Text == "Car Recipient" || UserLb.Text == "የመኪና መግቢያ ተቀባይ")
                    {

                        //this.Close();
                        //cr.Show();
                        //Hide();
                        Car_Recipient cr = new Car_Recipient(this, username, userId);
                        this.Hide();
                        cr.Show();
                    }

                    else if (UserLb.Text == "Pedestrian Recipient" || UserLb.Text == "የእግረኛ መግቢያ ተቀባይ")
                    {
                        Pedestrian_Recipient pr = new Pedestrian_Recipient(this, username, userId);

                        //this.Close();
                        //pr.Show();
                        //Hide();

                        //Pedestrian_Recipient pr = new Pedestrian_Recipient();
                        this.Hide();
                        pr.Show();
                    }

                    else
                    {
                        Exit_Gate eg = new Exit_Gate();
                        this.Hide();
                        eg.Show();
                    }

                }
            //}
            //catch (Exception mess)
            //{
            //    MessageBox.Show(mess.ToString());

            //}
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void LoginAs_Load(object sender, EventArgs e)
        {
            LoginPn.Hide();
            LangPn.Hide();
            
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

        private void CarBtn_Click(object sender, EventArgs e)
        {
            LoginPn.Show();
            ChooseLb.Hide();
           
            UserLb.Location = new Point(318, 210);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                UserLb.Text = "የመኪና መግቢያ ተቀባይ";
                UserLb.Location = new Point(291, 222);
                lang();
            }
            else
            {
                    UserLb.Text = "Car Recipient";
            }
            }

        private void PedBtn_Click(object sender, EventArgs e)
        {
            LoginPn.Show();
            ChooseLb.Hide();
            
            UserLb.Location = new Point(295, 210);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                UserLb.Text = "የእግረኛ መግቢያ ተቀባይ";
                UserLb.Location = new Point(295, 222);
                lang();
            }
            else
            {
                UserLb.Text = "Pedestrian Recipient";
            }
        }

        private void ExitGateBtn_Click(object sender, EventArgs e)
        {
            LoginPn.Show();
            ChooseLb.Hide();
            
            UserLb.Location = new Point(315, 210);
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                UserLb.Text = "የመውጫ በር ተቀባይ";
                UserLb.Location = new Point(300, 222);
                lang();
            }
            else
            {
                UserLb.Text = "Exit Recipient";
            }
        }
        void lang()
        {
            UsernameTb.Text = "";
            UsernameTb.HintText = "የተጠቃሚ ስም";
            PasswordTb.Text = "";
            PasswordTb.HintText = "የይለፍ ቃል";
            LoginBtn.ButtonText = "ግባ";
        }
        private void BackBtn1_Click(object sender, EventArgs e)
        {
            LoginPn.Hide();
            ChooseLb.Show();
            ShowBtn.BringToFront();
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET")) 
            {
                lang();
            }
            else
            {
                
                UsernameTb.Text = "";
                UsernameTb.HintText = "Username";
                PasswordTb.Text = "";
                PasswordTb.HintText = "Password";
            }
        }

        private void BackBtn1_MouseHover(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
               ToolTip1.SetToolTip(this.BackBtn1, "ተመለስ");
            }
            else ToolTip1.SetToolTip(this.BackBtn1, "Back");

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

       

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            HideBtn.BringToFront();
            PasswordTb.isPassword = false;
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            ShowBtn.BringToFront();
            PasswordTb.isPassword = true;
        }

        private int ClickCounter = 0;
        private int ClickCounter1 = 0;
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            InfoUc iu = new InfoUc();
            InfoPn.Controls.Add(iu);
            LangPn.Hide();
            LangBtn.Show();
            if (ClickCounter == 0)
            {
                InfoBtn.Image = Properties.Resources.xbtn;
                LangBtn.Image = Properties.Resources.Language_icon;
                InfoBtn.ImageSize = new Size(30, 30);
                InfoPn.Visible = true;
                InfoPn.BringToFront();
                ClickCounter++;
                ClickCounter1 = 0;
            }
            else if (ClickCounter == 1)
            {
                InfoBtn.Image = Properties.Resources.info;
                InfoBtn.ImageSize = new Size(40, 40);
                InfoPn.Visible = false;
                ClickCounter = 0;
            }
        }

        private void InfoBtn_MouseHover(object sender, EventArgs e)
        {
            if (ClickCounter == 0)
            {
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.InfoBtn, "መረጃ");
                }
                else ToolTip1.SetToolTip(this.InfoBtn, "info");
            }
            else
            {
                ToolTip1.SetToolTip(this.InfoBtn, "Close");
            }
        }

        private void LangBtn_Click(object sender, EventArgs e)
        {
            LangBtn.Hide();
            LangPn.Show();
        }

        private void LangBtn_MouseHover(object sender, EventArgs e)
        {
           
                if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
                {
                    ToolTip1.SetToolTip(this.LangBtn, "ቋንቋ");
                }
                else ToolTip1.SetToolTip(this.LangBtn, "Language");
          
            
        }

        private void PasswordTb_OnValueChanged(object sender, EventArgs e)
        {
            PasswordTb.isPassword = true;
        }

        private void ShowBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.ShowBtn, "Show Password");
        }

        private void HideBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.HideBtn, "Hide Password");
        }

        void create()
        {
            LoginAs la = new LoginAs();
            this.Hide();
            la.Show();
        }

        private void AmRb_CheckedChanged(object sender, EventArgs e)
        {
          
            var culture = CultureInfo.GetCultureInfo("am-ET");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            create();
        }

        private void EnRb_CheckedChanged(object sender, EventArgs e)
        {
            var culture = CultureInfo.GetCultureInfo("en");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            create();
        }

        private void InfoPn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
