using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest_Entry_Recording_System
{
    public partial class GuestsCarUc : UserControl
    {
        private readonly federal1Entities4 _db;
        private string _user;
        private int _id;
        public GuestsCarUc()
        {
            InitializeComponent();
            _db = new federal1Entities4();

        }
        public GuestsCarUc(Car_Recipient Car, int _id)
        {
            InitializeComponent();
            _db = new federal1Entities4();
            CarPopulatedGrid();
            GunPopulatedGrid();
        }
        public GuestsCarUc(string username, int id)
        {
            InitializeComponent();
            _user = username;
            _id = id;
            CarPopulatedGrid();
            GunPopulatedGrid();

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbLicenseNumber.Text) || string.IsNullOrWhiteSpace(tbTypeOfCar.Text) || string.IsNullOrWhiteSpace(tbPlateNumber.Text) || string.IsNullOrWhiteSpace(tbDestination.Text))
            {
                MessageBox.Show("Please Fill the fields correctly");
            }
            else
            {
                string GuestName = tbFirstName.Text;
                String LicenceNumber = tbLicenseNumber.Text;
                string TypeOfCar = tbTypeOfCar.Text;
                string PlateNumber = tbPlateNumber.Text;
                string DestinationOffice = tbDestination.Text;
                DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

                var Car = new car();
                Car.fname = GuestName;
                Car.licence_number = LicenceNumber;
                Car.car_type = TypeOfCar;
                Car.plate_number = PlateNumber;
                Car.dest_office = DestinationOffice;
                Car.created_at = DateIn;

                _db.cars.Add(Car);
                _db.SaveChanges();



                var Emp = _db.recipents.FirstOrDefault(q => q.id == _id);
                var EmpId = Emp.id;
                var _Guest = _db.guests.FirstOrDefault(q => q.fname == GuestName);
                var GuestId = _Guest.id;

                //var CarR = new CAR_RECIPANT();
                //CarR.emp_id = EmpId;
                //CarR.carGuest_id = GuestId;

                //_db.CAR_RECIPANT.Add(CarR);
                //_db.SaveChanges();

                MessageBox.Show($" {GuestName}'s Car is Registered succsusfully");
                CarPopulatedGrid();
            }
        }

        private void CarPopulatedGrid()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var Car = new car();

            var records = _db.cars.Select(q => new
            {
                GuestName = q.fname,
                LicenceNumber = q.licence_number,
                CarType = q.car_type,
                DestinationOffice = q.dest_office
            }).ToList();
            gvCar.DataSource = records;

        }
        private void GunPopulatedGrid()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var Car = new car();

            var records = _db.cars.Select(q => new
            {
                GuestName = q.fname,
                LicenceNumber = q.licence_number,
                CarType = q.car_type,
                DestinationOffice = q.dest_office
            }).ToList();
            gvCar.DataSource = records;
        }
        private void BtInsertGun_Click(object sender, EventArgs e)
        {
            // globa G = new globa();
            string GunOwner = tbGunOwner.Text;
            string TypeOfGun = tbTypeOfGun.Text;
            string CuponNumber = tbCouponNumber.Text;
            string SideNumber = tbSideNumber.Text;
            DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day); ;
            //tbGunOwner.Text = G.Gfname;

            var Gun = new gun();
            Gun.gun_type = TypeOfGun;
            Gun.cupon_number = CuponNumber;
            Gun.side_number = SideNumber;
            //Gun.fname = G.Gfname;
            Gun.fname = GunOwner;
            //Gun.Date = DateIn;

            _db.guns.Add(Gun);
            _db.SaveChanges();

            MessageBox.Show($"Guest name {GunOwner}\n\r" +
                    "Gun info Registered Successfully");
            GunPopulatedGrid();
        }

        private void TbGunSearch_OnValueChanged_1(object sender, EventArgs e)
        {
            var search = (TbGunSearch.Text).Trim();
            if (string.IsNullOrEmpty(search))
            {
                GunPopulatedGrid();
            }
            else
            {
                var data = _db.guns.Where(q => q.fname.Contains(search) || q.cupon_number.Contains(search) || q.side_number.Contains(search)).Select(
                                q => new
                                {
                                    GunOwner = q.fname,//+ " " + q.lname
                                    CuponNUmber = q.cupon_number,
                                    GunType = q.gun_type,
                                    SideNumber = q.side_number,
                                    Date = q.created_at
                                    //Time=q.entryTime.ToString("hh:mm:ss"),
                                    //timein = q.entryTime.ToString("hh:mm:ss"),
                                }).ToList();
                gvGun.DataSource = data;
            }
        }

        private void GvGun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    if (e.RowIndex >= 0)
                    {
                        AddToBtn.Show();
                        tbFirstName.Text = gvCar.Rows[e.RowIndex].Cells[0].Value.ToString();
                        tbLicenseNumber.Text = gvCar.Rows[e.RowIndex].Cells[1].Value.ToString();
                        tbTypeOfCar.Text = gvCar.Rows[e.RowIndex].Cells[2].Value.ToString();
                        tbPlateNumber.Text = gvCar.Rows[e.RowIndex].Cells[3].Value.ToString();
                        tbDestination.Text = gvCar.Rows[e.RowIndex].Cells[4].Value.ToString();
                        ProblesmsLb.Text = gvCar.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbGunOwner.Text) || string.IsNullOrWhiteSpace(tbTypeOfGun.Text))
            {
                MessageBox.Show("Please Fill the fields correctly");
            }
            else
            {
                string GunOwner = tbGunOwner.Text;
                string TypeOfGun = tbTypeOfGun.Text;
                string CuponNumber = tbCouponNumber.Text;
                string SideNumber = tbSideNumber.Text;
                DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day); ;
                //tbGunOwner.Text = G.Gfname;

                var Gun = new gun();
                Gun.gun_type = TypeOfGun;
                Gun.cupon_number = CuponNumber;
                Gun.side_number = SideNumber;
                //Gun.fname = G.Gfname;
                Gun.fname = GunOwner;
                Gun.created_at = DateIn;

                _db.guns.Add(Gun);
                _db.SaveChanges();

                MessageBox.Show($"Guest name {GunOwner}\n\r" +
                        "Gun info Registered Successfully");
                GunPopulatedGrid();
            }
        }

        private void BtnCarClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbLicenseNumber.Text = "";
            tbTypeOfCar.Text = "";
            tbPlateNumber.Text = "";
            tbDestination.Text = "";
            tbProblem.Text = "";
        }
    }
    }
