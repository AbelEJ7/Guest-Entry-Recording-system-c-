using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Guest_Entry_Recording_System
{
    public partial class SettingsUcPeds : UserControl
    {
        ToolTip ToolTip1 = new ToolTip();
        public SettingsUcPeds()
        {
            InitializeComponent();
        }

        private void SettingsUcPeds_Load(object sender, EventArgs e)
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

        Bitmap b;
        Image i;
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

    }
}
