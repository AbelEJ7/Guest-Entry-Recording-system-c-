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
    public partial class DashCarUc : UserControl
    {
        private readonly federal1Entities4 _db;
        public string _user;
        public int _Id;

        public DashCarUc()
        {
            InitializeComponent();
            _db = new federal1Entities4();
        }
        public DashCarUc(string username, int id)
        {
            InitializeComponent();
            _db = new federal1Entities4();
            _user = username;
            _Id = id;
            lbFirstName.Text = _user;
            
           lbName.Text = _user;

            //GuestsToday();
            CarsToday();
        }
        public void CarsToday()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var count = _db.cars.Count(b => b.created_at == todaysDate);
            lbcar.Text = count.ToString();

        }
        public void GuestWithCarToday()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            // var count = _db..Count(b => b.Date == todaysDate);
            //lbGuestWithCar.Text = count.ToString();

        }
    }
}
