using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest_Entry_Recording_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private static int Shadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Shadow;
                return cp;
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            ProgressPN1.Width += 3;

            if (ProgressPN1.Width >= 1000)
            {
                ProgressTimer.Stop();
                LoginAs la = new LoginAs();
                this.Hide();
                la.Show();

            }
        }
    }
}
