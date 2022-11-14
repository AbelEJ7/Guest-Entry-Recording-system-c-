using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;

namespace Guest_Entry_Recording_System
{
    public partial class GuestsPedUc : UserControl
    {
        private readonly federal1Entities4 _db;
        private int _id;
        DateTime todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        public GuestsPedUc()
        {
            InitializeComponent();
            _db = new federal1Entities4();

        }
        public GuestsPedUc(Pedestrian_Recipient ped, int id)
        {
            InitializeComponent();
            _db = new federal1Entities4();
            GuestpopulateGrid();
            GunPopulatedGrid();
            InternsPopulatedGrid();
            WeekendPopulatedGrid();
            _id = id;
        }
        public class globa
        {
            public string Gfname;

        }
        public void addGuest(string t)
        {
            String[] spearator = { ">" };

            // using the method
            String[] strlist = t.Split(spearator,
               StringSplitOptions.RemoveEmptyEntries);
            /*****ge values***/
            globa G = new globa();

            G.Gfname = strlist[2];
           // string lname = tbLastName.Text;
            string Idnumber = strlist[0];
            string Subcity = strlist[6];
            string PhoneNumber = strlist[7];
            //string Destination = strlist[2];
            //string Woreda = tbWoreda.Text;
            DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                    DateTime D = DateTime.Today;

            var user = _db.guests.FirstOrDefault(q => q.created_at == todaysDate && q.id_number == Idnumber);
            if( user == null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                    QrScannerPb.Image = Properties.Resources.Scanner1;
                    StartBtn.Enabled = true;
                    StopBtn.Enabled = false;
                }
                var Guest = new guest();
                Guest.fname = G.Gfname;
                Guest.id_number = Idnumber;
                Guest.sub_city = Subcity;
                Guest.phone_number = PhoneNumber;
                   Guest.created_at = DateIn;
                Guest.isin = true;

                string Destination = Interaction.InputBox("Enter Destination String:", "Destination","",200, 200);

                if(Destination != "")
                {
                         Guest.dest_office = Destination;
                }
                else
                {
                    MessageBox.Show("Enter Destination");
                    return;
                }
               
                _db.guests.Add(Guest);
                _db.SaveChanges();
                MessageBox.Show("Guest Added Succusfully");
                GuestpopulateGrid();
            }
            else
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                    QrScannerPb.Image = Properties.Resources.Scanner1;
                    StartBtn.Enabled = true;
                    StopBtn.Enabled = false;
                }
                MessageBox.Show("Guest Exist in todays List");
            }
            
        }
        private void Insertbtn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbIdNumber.Text) || string.IsNullOrWhiteSpace(tbSubcity.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text) || string.IsNullOrWhiteSpace(tbWoreda.Text))
            //{
            //    MessageBox.Show("Please Fill the fields correctly");
            //}
            //else
            //{
            //    try
            //    {

            //        globa G = new globa();

            //        //G.Gfname = tbFirstName.Text;
            //        //string lname = tbLastName.Text;
            //        //string Idnumber = tbIdNumber.Text;
            //        //string Subcity = tbSubcity.Text;
            //        //string PhoneNumber = tbPhoneNumber.Text;
            //        //string Destination = tbDestinationOffice.Text;
            //        //string Woreda = tbWoreda.Text;

            //        DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            //        DateTime D = DateTime.Today;

            //        //object of record


            //        var todaychecker = _db.guests.FirstOrDefault(q => q.created_at == todaysDate && q.id_number == Idnumber);
            //        var allchecker = _db.guests.FirstOrDefault(q => q.created_at == todaysDate && q.id_number == Idnumber);

            //        //if (todaychecker == null)
            //        //{
            //        //    if (allchecker == null)
            //        //    {
            //        //var Guest = new guest();
            //        //Guest.fname = G.Gfname;
            //        //Guest.lname = lname;
            //        //Guest.id_number = Idnumber;
            //        //Guest.sub_city = Subcity;
            //        //Guest.phone_number = PhoneNumber;
            //        //Guest.dest_office = Destination;
            //        //Guest.woreda = Woreda;
            //        //Guest.created_at = DateIn;


            //        // Guest.isin = true;


            //        //_db.guests.Add(Guest);
            //        //_db.SaveChanges();

            //        //var Employee = new recipent();
            //        //var Emp = _db.recipents.FirstOrDefault(q => q.id == _id);
            //        //var EmpId = Emp.id;
            //        //var _Guest = _db.guests.FirstOrDefault(q => q.fname == G.Gfname);
            //        //var _GuestId = _Guest.id;

            //        //var Recipant = new guest_recipents();

            //        //Recipant.recipents_id = Convert.ToInt32(EmpId);
            //        //Recipant.guest_id = Convert.ToInt32(_GuestId);

            //        //_db.guest_recipents.Add(Recipant);
            //        //_db.SaveChanges();



            //        //MessageBox.Show($"Guest name {G.Gfname}\n\r" +
            //        //        "Registered Successfully");
            //        //GuestpopulateGrid();
            //        //clear();
            //        //    }
            //        //    else
            //        //    {
            //        //        MessageBox.Show(" Id card exists ");

            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("user exist in todays list");
            //        //}



            //    }
            //    catch (Exception mess)
            //    {

            //        MessageBox.Show(mess.ToString());
            //    }
            //}
        }

        public void GuestpopulateGrid()
        {


            var records = _db.guests.Where(b => b.created_at == todaysDate).Select(q => new
            {
                Guest = q.fname + " " + q.lname,
                idNumber = q.id_number,
                subcity = q.sub_city,
                phone = q.phone_number,
                destination = q.dest_office,
                Id = q.id,
                DateT = q.created_at,
                //Time=q.entryTime.ToString("hh:mm:ss"),
                //timein = q.entryTime.ToString("hh:mm:ss"),
            }).ToList();
            gvGuest.DataSource = records;
            //gvGuest.Columns["guest_id"].Visible = false;
            gvGuest.Columns[0].HeaderText = "Full Name";
            gvGuest.Columns["Id"].Visible = false;
            
        }
        private void clear()
        {
        //    tbFirstName.Text = "";
        //    tbIdNumber.Text = "";
        //    tbSubcity.Text = "";
        //    tbPhoneNumber.Text = "";
        //    tbDestinationOffice.Text = "";
        //    tbWoreda.Text = "";
        //    tbLastName.Text = "";
        }

        private void BtInsertGun_Click(object sender, EventArgs e)
        {
            // globa G = new globa();
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
                DateTime DateIn = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
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

        private void GunPopulatedGrid()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var Guest = new guest();

            var records = _db.guns.Where(q => q.created_at == todaysDate).Select(q => new
            {
                GunOwner = q.fname,//+ " " + q.lname
                CuponNUmber = q.cupon_number,
                GunType = q.gun_type,
                SideNumber = q.side_number,
                Date = q.created_at
            }).ToList();
            gvGun.DataSource = records;
        }
        private void InternsPopulatedGrid()
        {
            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var Guest = new guest();

            var records = _db.interns.Where(q => q.status=="active").Select(q => new
            {
                intern = q.fname + " " + q.lname ,
                //idNumber = q.,
                school = q.school,
                role = q.role,
                Id = q.id,
                DateT = q.created_at,
            }).ToList();

            gvIntern.DataSource = records;
        }


        ///********************///



        public FilterInfoCollection filterInfoCollection;
        public FilterInfoCollection filterInfoCollection1;
        public VideoCaptureDevice captureDevice;
        public VideoCaptureDevice captureDevice1;



        private void StartBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
           
        }

       

        public void stopCamera()
        {
            if (captureDevice != null)
            {
            captureDevice.Stop();
            timer1.Stop();
            QrScannerPb.Image = Properties.Resources.Scanner1;
            StopBtn.Enabled = false;
            StartBtn.Enabled = true;
            }
           
        }

        public void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            QrScannerPb.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void GuestsPedUc_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            filterInfoCollection1 = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
                cboDevice.Items.Add(filterinfo.Name);
            cboDevice.SelectedIndex = 0;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (QrScannerPb.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)QrScannerPb.Image);
                if (result != null)
                {
                    federal1Entities4 buga = new federal1Entities4();
                    //txtqr.Text = result.ToString();
                    var text = result.ToString();
                        
                    // var checker = _db.interns.FirstOrDefault(q => q.intern_id == buga).ToList;
                    checker(text);
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
            
        }
        

        private void checker(string text)
        {
            if (text != null)
            {
                Form formbackground = new Form();
                try
                {
                    var buga = text;
                    var checke = _db.interns.FirstOrDefault(q => q.School_id == buga);

                    if (text != null)
                    {

                        if (text.Contains(">"))
                        {
                            addGuest(text);
                        }
                        else if (checke != null)
                        {
                            timer1.Stop();
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.Stop();
                                QrScannerPb.Image = Properties.Resources.Scanner1;
                                StartBtn.Enabled = true;
                                StopBtn.Enabled = false;
                            }
                            Internsid interr = new Internsid(checke);
                            formbackground.FormBorderStyle = FormBorderStyle.None;
                            formbackground.Opacity = .70d;
                            formbackground.BackColor = Color.Black;
                            formbackground.TopMost = true;
                            formbackground.ShowInTaskbar = false;
                            interr.Owner = formbackground;
                            interr.ShowDialog();
                            formbackground.Dispose();
                            captureDevice.Stop();
                            //InternUc iu = new InternUc();
                            //addusrtControl(iu);
                            //MessageBox.Show("hello "+ checke.intern_id.ToString());
                        }
                        else
                        {
                            captureDevice.Stop();
                            QrScannerPb.Image = Properties.Resources.Scanner1;
                            StartBtn.Enabled = true;
                            StopBtn.Enabled = false;
                            MessageBox.Show("Sorry this information is not Available :(");
                            QrScannerPb.Image = Properties.Resources.Scanner1;
                        }



                       
                    }
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    formbackground.Dispose();
                }
            }
        }
        
        private void TbGuestInfoSearch_OnValueChanged_1(object sender, EventArgs e)
        {
            var search = (TbGuestInfoSearch.Text).Trim();
            if (string.IsNullOrEmpty(search))
            {
                GuestpopulateGrid();
            }
            else
            {
                var data = _db.guests.Where(q => q.fname.Contains(search) || q.id_number.Contains(search) || q.phone_number.Contains(search)).Select(
                 q => new {
                     Guest = q.fname,//+ " " + q.lname
                     idNumber = q.id_number,
                     subcity = q.sub_city,
                     phone = q.phone_number,
                     destination = q.dest_office,
                     Id = q.id,
                     DateT = q.created_at,
                     //Time=q.entryTime.ToString("hh:mm:ss"),
                     //timein = q.entryTime.ToString("hh:mm:ss"),
                 }).ToList();
                gvGuest.DataSource = data;
            }
        }
        public void WeekendPopulatedGrid()
        {
            var data = _db.weekends.Where(b => b.from >= todaysDate && todaysDate  <= b.to && b.status == "accepted"   ).Select(
               q => new {
                   FullName = q.name,//+ " " + q.lname
                   Reason = q.reason,
                   
                   workDate = todaysDate,
                   //Time=q.entryTime.ToString("hh:mm:ss"),
                   //timein = q.entryTime.ToString("hh:mm:ss"),
               }).ToList();
            gvWeekend.DataSource = data;
        }
        private void TbWeekendSearch_OnValueChanged_1(object sender, EventArgs e)
        {
            var search = (TbWeekendSearch.Text).Trim();
            if (string.IsNullOrEmpty(search))
            {
                WeekendPopulatedGrid();
            }
            else
            {
                //var data = _db.weekends.Where(q => q.fname.Contains(search)).Select(
                //                q => new
                //                {
                //                    employeNmae = q.fname,//+ " " + q.lname
                //                    idNumber = q.id,
                //                    Date = q.assigned_date
                //                    //subcity = q.GUEST.sub_city,
                //                    //phone = q.GUEST.phone_number,
                //                    //destination = q.GUEST.dest_office,
                //                    //Id = q.guest_id,
                //                    //DateT = q.GUEST.entry_date,
                //                    //Time=q.entryTime.ToString("hh:mm:ss"),
                //                    //timein = q.entryTime.ToString("hh:mm:ss"),
                //                }).ToList();
                //gvWeekend.DataSource = data;
            }
        }

        private void TbInternsSearch_OnValueChanged_1(object sender, EventArgs e)
        {
            var search = (TbInternsSearch.Text).Trim();
            if (string.IsNullOrEmpty(search))
            {
                GunPopulatedGrid();
            }
            else
            {
                var data = _db.interns.Where(q => q.fname.Contains(search) || q.phone.Contains(search)).Select(
                                q => new
                                {
                                    intern = q.fname,//+ " " + q.lname
                                    school_id = q.id,

                                    phone = q.phone,
                                    role = q.role,
                                    Id = q.id,
                                    DateT = q.created_at,
                                    //Time=q.entryTime.ToString("hh:mm:ss"),
                                    //timein = q.entryTime.ToString("hh:mm:ss"),
                                }).ToList();
                gvGun.DataSource = data;
            }
        }

        private void TbGunSearch_OnValueChanged(object sender, EventArgs e)
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

        

        private void GvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (tbFirstName.Visible)
            //    {
            //        if (e.RowIndex >= 0)
            //        {
            //            AddToBtn.Show();
            //            tbFirstName.Text = gvGuest.Rows[e.RowIndex].Cells[0].Value.ToString();
            //            tbIdNumber.Text = gvGuest.Rows[e.RowIndex].Cells[1].Value.ToString();
            //            tbSubcity.Text = gvGuest.Rows[e.RowIndex].Cells[2].Value.ToString();
            //            tbWoreda.Text = gvGuest.Rows[e.RowIndex].Cells[5].Value.ToString();
            //            tbPhoneNumber.Text = gvGuest.Rows[e.RowIndex].Cells[3].Value.ToString();
            //            tbDestinationOffice.Text = gvGuest.Rows[e.RowIndex].Cells[4].Value.ToString();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    AddToBtn.Hide();
            //}
        }

        private void GvGun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TimUpdate_Tick(object sender, EventArgs e)
        {
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //tbFirstName.Text = "";
            //tbLastName.Text = "";
            //tbIdNumber.Text = "";
            //tbSubcity.Text = "";
            //tbWoreda.Text = "";
            //tbPhoneNumber.Text = "";
            //tbDestinationOffice.Text = "";
        }

        private void ClearBtn2_Click(object sender, EventArgs e)
        {
            tbGunOwner.Text = "";
            tbTypeOfGun.Text = "";
            tbSideNumber.Text = "";
            tbCouponNumber.Text = "";
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            timer1.Start();
        }

        private void StopBtn_Click_1(object sender, EventArgs e)
        {
            stopCamera();
        }
    }
}
