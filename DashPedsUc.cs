using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guest_Entry_Recording_System
{
    public partial class DashPedsUc : UserControl
    {
        private readonly federal1Entities4 _db;
        public string _user;
        public int _id;
        public DashPedsUc()
        {
            InitializeComponent();
            _db = new federal1Entities4();
            GuestsToday();
            GunToday();
            GunIn();
            Guestin();
        }
        public DashPedsUc(string user, int id)
        {
            InitializeComponent();
            _db = new federal1Entities4();
            _user = user;
            _id = id;
            lbFullName.Text = _user;
            //var img = getphoto(_id);
            //pbProfile.Image = img;
            lbName.Text = _user;
            lbid.Text = _id.ToString();

            GuestsToday();
            GunToday();
        }
        
        public void GuestsToday()
        {

            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var count = _db.guests.Count(b => b.created_at == todaysDate);
            lbguest.Text = count.ToString();

        }
        public void GunToday()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var count = _db.guns.Count(b => b.created_at == todaysDate);
            lbgun.Text = count.ToString();
        }
        public void GunIn()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var count = _db.guns.Count(b => b.created_at == todaysDate && b.isTaken == true);
            lbGunInCompound.Text = count.ToString();
        }
        public void Guestin()
        {

            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var count = _db.guests.Count(b => b.created_at == todaysDate && b.isin == true);
            lbGuestInCompound.Text = count.ToString();

        }
        private void LbCar_Click(object sender, EventArgs e)
        {

        }
    }

}
