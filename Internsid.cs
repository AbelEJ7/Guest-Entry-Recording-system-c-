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
    public partial class Internsid : Form
    {
        private readonly federal1Entities4 _db;
        public Internsid()
        {
            InitializeComponent();
        }
        public Internsid(intern obj)
        {

            InitializeComponent();
            _db = new federal1Entities4();
            set(obj);
        }
        public void set(intern obj)
        {
            var name = obj.fname;
            var lname = obj.lname;
            var phone = obj.phone;
            var school = obj.school;
            var id = obj.id;
            lbInternId.Text = id.ToString();
            lbLName.Text = lname;
            lbPhoneNumber.Text = phone;
            lbFName.Text = name;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
