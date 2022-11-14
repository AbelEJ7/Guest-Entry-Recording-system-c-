using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Globalization;

namespace Guest_Entry_Recording_System
{
    public partial class SettingsUcCars : UserControl
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice VideoDevices;
        ToolTip ToolTip1 = new ToolTip();

        public SettingsUcCars()
        {
            InitializeComponent();
            getallcameralist();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        void getallcameralist()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in CaptureDevice) { CameraTypeCb.Items.Add(Devices.Name); }
        }


        private void Setprofilelbl_Click_1(object sender, EventArgs e)
        {
            // setprofile1.Visible = true;

        }

        private void SettingsUcCars_Load_1(object sender, EventArgs e)
        {
            if (CultureInfo.DefaultThreadCurrentCulture == CultureInfo.GetCultureInfo("am-ET"))
            {
                UsernameBox.HintText = "የተጠቃሚ ስም";
                FirstNameBox.HintText = "ስም";
                LastNameBox.HintText = "የአባት ስም";
                PhoneNumberBox.HintText = "ስልክ ቁጥር";
                PassBox.HintText = "የይለፍ ቃል";
                
            }
        }

        private void Initiatebtn_Click(object sender, EventArgs e)
        {
            lbInitiate.Hide();
            try
            {
                VideoDevices = new VideoCaptureDevice(CaptureDevice[CameraTypeCb.SelectedIndex].MonikerString);
                VideoDevices.NewFrame += new NewFrameEventHandler(NewVideoFrame);
                VideoDevices.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewVideoFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Capturebtn_Click(object sender, EventArgs e)
        {

            try
            {
                pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Image As";
                sfd.Filter = "Image files(*.jpg,*.png)|*.jpg;*.png";
                ImageFormat imageFormat = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            imageFormat = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox2.Image.Save(sfd.FileName, imageFormat);
                    MessageBox.Show("You Have delivered your photo successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Image i;
        Bitmap b;
        private void Stopbtn_Click(object sender, EventArgs e)
        {
            if (VideoDevices.IsRunning == true)
            {
                VideoDevices.Stop();
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Allow this app to access your file?", "Allow", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult1 == DialogResult.Yes)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    i = Image.FromFile(ofd.FileName);
                    b = (Bitmap)i;
                    ProfilePb.Image = b;
                }
            }
        }

        private void BrowseBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.BrowseBtn, "Browse File");
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ProfilePb.Image = Properties.Resources.Account;
        }
    }
}
