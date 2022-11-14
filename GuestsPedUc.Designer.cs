namespace Guest_Entry_Recording_System
{
    partial class GuestsPedUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsPedUc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GuestTc = new System.Windows.Forms.TabControl();
            this.GuestInfoTp = new System.Windows.Forms.TabPage();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.CameraLb = new System.Windows.Forms.Label();
            this.StartBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.QrScannerPb = new System.Windows.Forms.PictureBox();
            this.StopBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.TbGuestInfoSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gvGuest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.GunInfoTp = new System.Windows.Forms.TabPage();
            this.GunInfoTlp = new System.Windows.Forms.TableLayoutPanel();
            this.GonLb = new Guna.UI.WinForms.GunaLabel();
            this.tbSideNumber = new System.Windows.Forms.TextBox();
            this.CoupLb = new Guna.UI.WinForms.GunaLabel();
            this.SideNLb = new Guna.UI.WinForms.GunaLabel();
            this.TogLb = new Guna.UI.WinForms.GunaLabel();
            this.tbTypeOfGun = new System.Windows.Forms.TextBox();
            this.tbCouponNumber = new System.Windows.Forms.TextBox();
            this.tbGunOwner = new System.Windows.Forms.TextBox();
            this.TbGunSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gvGun = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ClearBtn2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btInsertGun = new Guna.UI.WinForms.GunaAdvenceButton();
            this.InternsTp = new System.Windows.Forms.TabPage();
            this.gunaCirclePictureBox3 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.TbInternsSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gvIntern = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.WETp = new System.Windows.Forms.TabPage();
            this.TbWeekendSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gvWeekend = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaCirclePictureBox4 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timUpdate = new System.Windows.Forms.Timer(this.components);
            this.GuestTc.SuspendLayout();
            this.GuestInfoTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrScannerPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuest)).BeginInit();
            this.GunInfoTp.SuspendLayout();
            this.GunInfoTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.InternsTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIntern)).BeginInit();
            this.WETp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWeekend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestTc
            // 
            resources.ApplyResources(this.GuestTc, "GuestTc");
            this.GuestTc.Controls.Add(this.GuestInfoTp);
            this.GuestTc.Controls.Add(this.GunInfoTp);
            this.GuestTc.Controls.Add(this.InternsTp);
            this.GuestTc.Controls.Add(this.WETp);
            this.GuestTc.Name = "GuestTc";
            this.GuestTc.SelectedIndex = 0;
            // 
            // GuestInfoTp
            // 
            this.GuestInfoTp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GuestInfoTp.Controls.Add(this.cboDevice);
            this.GuestInfoTp.Controls.Add(this.CameraLb);
            this.GuestInfoTp.Controls.Add(this.StartBtn);
            this.GuestInfoTp.Controls.Add(this.QrScannerPb);
            this.GuestInfoTp.Controls.Add(this.StopBtn);
            this.GuestInfoTp.Controls.Add(this.gunaCirclePictureBox2);
            this.GuestInfoTp.Controls.Add(this.TbGuestInfoSearch);
            this.GuestInfoTp.Controls.Add(this.gvGuest);
            resources.ApplyResources(this.GuestInfoTp, "GuestInfoTp");
            this.GuestInfoTp.Name = "GuestInfoTp";
            // 
            // cboDevice
            // 
            resources.ApplyResources(this.cboDevice, "cboDevice");
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Name = "cboDevice";
            // 
            // CameraLb
            // 
            resources.ApplyResources(this.CameraLb, "CameraLb");
            this.CameraLb.ForeColor = System.Drawing.Color.Navy;
            this.CameraLb.Name = "CameraLb";
            // 
            // StartBtn
            // 
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.StartBtn.AnimationHoverSpeed = 0.07F;
            this.StartBtn.AnimationSpeed = 0.03F;
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.StartBtn.BorderColor = System.Drawing.Color.Black;
            this.StartBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.StartBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.StartBtn.CheckedForeColor = System.Drawing.Color.White;
            this.StartBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("StartBtn.CheckedImage")));
            this.StartBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartBtn.FocusedColor = System.Drawing.Color.Empty;
            this.StartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StartBtn.Image = null;
            this.StartBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.StartBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StartBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StartBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.StartBtn.OnHoverImage = null;
            this.StartBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StartBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StartBtn.Radius = 20;
            this.StartBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // QrScannerPb
            // 
            resources.ApplyResources(this.QrScannerPb, "QrScannerPb");
            this.QrScannerPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QrScannerPb.Image = global::Guest_Entry_Recording_System.Properties.Resources.Scanner1;
            this.QrScannerPb.Name = "QrScannerPb";
            this.QrScannerPb.TabStop = false;
            // 
            // StopBtn
            // 
            resources.ApplyResources(this.StopBtn, "StopBtn");
            this.StopBtn.AnimationHoverSpeed = 0.07F;
            this.StopBtn.AnimationSpeed = 0.03F;
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.StopBtn.BorderColor = System.Drawing.Color.Black;
            this.StopBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.StopBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.StopBtn.CheckedForeColor = System.Drawing.Color.White;
            this.StopBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("StopBtn.CheckedImage")));
            this.StopBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.StopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StopBtn.FocusedColor = System.Drawing.Color.Empty;
            this.StopBtn.ForeColor = System.Drawing.Color.Red;
            this.StopBtn.Image = null;
            this.StopBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.StopBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StopBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StopBtn.OnHoverForeColor = System.Drawing.Color.Red;
            this.StopBtn.OnHoverImage = null;
            this.StopBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StopBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.StopBtn.Radius = 20;
            this.StopBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click_1);
            // 
            // gunaCirclePictureBox2
            // 
            resources.ApplyResources(this.gunaCirclePictureBox2, "gunaCirclePictureBox2");
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::Guest_Entry_Recording_System.Properties.Resources.search;
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // TbGuestInfoSearch
            // 
            resources.ApplyResources(this.TbGuestInfoSearch, "TbGuestInfoSearch");
            this.TbGuestInfoSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbGuestInfoSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbGuestInfoSearch.HintForeColor = System.Drawing.Color.Empty;
            this.TbGuestInfoSearch.HintText = "ፈልግ";
            this.TbGuestInfoSearch.isPassword = false;
            this.TbGuestInfoSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbGuestInfoSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbGuestInfoSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.TbGuestInfoSearch.LineThickness = 3;
            this.TbGuestInfoSearch.Name = "TbGuestInfoSearch";
            this.TbGuestInfoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbGuestInfoSearch.OnValueChanged += new System.EventHandler(this.TbGuestInfoSearch_OnValueChanged_1);
            // 
            // gvGuest
            // 
            this.gvGuest.AllowUserToAddRows = false;
            this.gvGuest.AllowUserToDeleteRows = false;
            this.gvGuest.AllowUserToResizeColumns = false;
            this.gvGuest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvGuest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.gvGuest, "gvGuest");
            this.gvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvGuest.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvGuest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGuest.DoubleBuffered = true;
            this.gvGuest.EnableHeadersVisualStyles = false;
            this.gvGuest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.gvGuest.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.gvGuest.Name = "gvGuest";
            this.gvGuest.ReadOnly = true;
            this.gvGuest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvGuest.RowHeadersVisible = false;
            this.gvGuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvGuest_CellClick);
            // 
            // GunInfoTp
            // 
            this.GunInfoTp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GunInfoTp.Controls.Add(this.GunInfoTlp);
            this.GunInfoTp.Controls.Add(this.TbGunSearch);
            this.GunInfoTp.Controls.Add(this.gvGun);
            this.GunInfoTp.Controls.Add(this.gunaCirclePictureBox1);
            this.GunInfoTp.Controls.Add(this.ClearBtn2);
            this.GunInfoTp.Controls.Add(this.btInsertGun);
            resources.ApplyResources(this.GunInfoTp, "GunInfoTp");
            this.GunInfoTp.Name = "GunInfoTp";
            // 
            // GunInfoTlp
            // 
            resources.ApplyResources(this.GunInfoTlp, "GunInfoTlp");
            this.GunInfoTlp.Controls.Add(this.GonLb, 0, 0);
            this.GunInfoTlp.Controls.Add(this.tbSideNumber, 3, 1);
            this.GunInfoTlp.Controls.Add(this.CoupLb, 0, 1);
            this.GunInfoTlp.Controls.Add(this.SideNLb, 2, 1);
            this.GunInfoTlp.Controls.Add(this.TogLb, 2, 0);
            this.GunInfoTlp.Controls.Add(this.tbTypeOfGun, 3, 0);
            this.GunInfoTlp.Controls.Add(this.tbCouponNumber, 1, 1);
            this.GunInfoTlp.Controls.Add(this.tbGunOwner, 1, 0);
            this.GunInfoTlp.Name = "GunInfoTlp";
            // 
            // GonLb
            // 
            resources.ApplyResources(this.GonLb, "GonLb");
            this.GonLb.BackColor = System.Drawing.Color.Transparent;
            this.GonLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.GonLb.Name = "GonLb";
            // 
            // tbSideNumber
            // 
            resources.ApplyResources(this.tbSideNumber, "tbSideNumber");
            this.tbSideNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.tbSideNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.tbSideNumber.Name = "tbSideNumber";
            // 
            // CoupLb
            // 
            resources.ApplyResources(this.CoupLb, "CoupLb");
            this.CoupLb.BackColor = System.Drawing.Color.Transparent;
            this.CoupLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.CoupLb.Name = "CoupLb";
            // 
            // SideNLb
            // 
            resources.ApplyResources(this.SideNLb, "SideNLb");
            this.SideNLb.BackColor = System.Drawing.Color.Transparent;
            this.SideNLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.SideNLb.Name = "SideNLb";
            // 
            // TogLb
            // 
            resources.ApplyResources(this.TogLb, "TogLb");
            this.TogLb.BackColor = System.Drawing.Color.Transparent;
            this.TogLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TogLb.Name = "TogLb";
            // 
            // tbTypeOfGun
            // 
            resources.ApplyResources(this.tbTypeOfGun, "tbTypeOfGun");
            this.tbTypeOfGun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.tbTypeOfGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.tbTypeOfGun.Name = "tbTypeOfGun";
            // 
            // tbCouponNumber
            // 
            resources.ApplyResources(this.tbCouponNumber, "tbCouponNumber");
            this.tbCouponNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.tbCouponNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.tbCouponNumber.Name = "tbCouponNumber";
            // 
            // tbGunOwner
            // 
            resources.ApplyResources(this.tbGunOwner, "tbGunOwner");
            this.tbGunOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.tbGunOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.tbGunOwner.Name = "tbGunOwner";
            // 
            // TbGunSearch
            // 
            resources.ApplyResources(this.TbGunSearch, "TbGunSearch");
            this.TbGunSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbGunSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbGunSearch.HintForeColor = System.Drawing.Color.Empty;
            this.TbGunSearch.HintText = "ፈልግ";
            this.TbGunSearch.isPassword = false;
            this.TbGunSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbGunSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbGunSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.TbGunSearch.LineThickness = 3;
            this.TbGunSearch.Name = "TbGunSearch";
            this.TbGunSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbGunSearch.OnValueChanged += new System.EventHandler(this.TbGunSearch_OnValueChanged);
            // 
            // gvGun
            // 
            this.gvGun.AllowUserToAddRows = false;
            this.gvGun.AllowUserToDeleteRows = false;
            this.gvGun.AllowUserToResizeColumns = false;
            this.gvGun.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvGun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.gvGun, "gvGun");
            this.gvGun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvGun.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvGun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvGun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvGun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvGun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGun.DoubleBuffered = true;
            this.gvGun.EnableHeadersVisualStyles = false;
            this.gvGun.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.gvGun.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.gvGun.MultiSelect = false;
            this.gvGun.Name = "gvGun";
            this.gvGun.ReadOnly = true;
            this.gvGun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvGun.RowHeadersVisible = false;
            this.gvGun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvGun_CellClick);
            // 
            // gunaCirclePictureBox1
            // 
            resources.ApplyResources(this.gunaCirclePictureBox1, "gunaCirclePictureBox1");
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Guest_Entry_Recording_System.Properties.Resources.search;
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ClearBtn2
            // 
            resources.ApplyResources(this.ClearBtn2, "ClearBtn2");
            this.ClearBtn2.AnimationHoverSpeed = 0.07F;
            this.ClearBtn2.AnimationSpeed = 0.03F;
            this.ClearBtn2.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.ClearBtn2.BorderColor = System.Drawing.Color.Black;
            this.ClearBtn2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ClearBtn2.CheckedBorderColor = System.Drawing.Color.Black;
            this.ClearBtn2.CheckedForeColor = System.Drawing.Color.White;
            this.ClearBtn2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn2.CheckedImage")));
            this.ClearBtn2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ClearBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearBtn2.FocusedColor = System.Drawing.Color.Empty;
            this.ClearBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.ClearBtn2.Image = null;
            this.ClearBtn2.ImageSize = new System.Drawing.Size(20, 20);
            this.ClearBtn2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClearBtn2.Name = "ClearBtn2";
            this.ClearBtn2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.ClearBtn2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.ClearBtn2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.ClearBtn2.OnHoverImage = null;
            this.ClearBtn2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.ClearBtn2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.ClearBtn2.Radius = 20;
            this.ClearBtn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearBtn2.Click += new System.EventHandler(this.ClearBtn2_Click);
            // 
            // btInsertGun
            // 
            resources.ApplyResources(this.btInsertGun, "btInsertGun");
            this.btInsertGun.AnimationHoverSpeed = 0.07F;
            this.btInsertGun.AnimationSpeed = 0.03F;
            this.btInsertGun.BackColor = System.Drawing.Color.Transparent;
            this.btInsertGun.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.btInsertGun.BorderColor = System.Drawing.Color.Black;
            this.btInsertGun.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btInsertGun.CheckedBorderColor = System.Drawing.Color.Black;
            this.btInsertGun.CheckedForeColor = System.Drawing.Color.White;
            this.btInsertGun.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btInsertGun.CheckedImage")));
            this.btInsertGun.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btInsertGun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInsertGun.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btInsertGun.FocusedColor = System.Drawing.Color.Empty;
            this.btInsertGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.btInsertGun.Image = null;
            this.btInsertGun.ImageSize = new System.Drawing.Size(20, 20);
            this.btInsertGun.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btInsertGun.Name = "btInsertGun";
            this.btInsertGun.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.btInsertGun.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.btInsertGun.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.btInsertGun.OnHoverImage = null;
            this.btInsertGun.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.btInsertGun.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.btInsertGun.Radius = 20;
            this.btInsertGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btInsertGun.Click += new System.EventHandler(this.BtInsertGun_Click);
            // 
            // InternsTp
            // 
            this.InternsTp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InternsTp.Controls.Add(this.gunaCirclePictureBox3);
            this.InternsTp.Controls.Add(this.TbInternsSearch);
            this.InternsTp.Controls.Add(this.gvIntern);
            resources.ApplyResources(this.InternsTp, "InternsTp");
            this.InternsTp.Name = "InternsTp";
            // 
            // gunaCirclePictureBox3
            // 
            resources.ApplyResources(this.gunaCirclePictureBox3, "gunaCirclePictureBox3");
            this.gunaCirclePictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox3.Image = global::Guest_Entry_Recording_System.Properties.Resources.search;
            this.gunaCirclePictureBox3.Name = "gunaCirclePictureBox3";
            this.gunaCirclePictureBox3.TabStop = false;
            this.gunaCirclePictureBox3.UseTransfarantBackground = false;
            // 
            // TbInternsSearch
            // 
            resources.ApplyResources(this.TbInternsSearch, "TbInternsSearch");
            this.TbInternsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbInternsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbInternsSearch.HintForeColor = System.Drawing.Color.Empty;
            this.TbInternsSearch.HintText = "ፈልግ";
            this.TbInternsSearch.isPassword = false;
            this.TbInternsSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbInternsSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbInternsSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.TbInternsSearch.LineThickness = 3;
            this.TbInternsSearch.Name = "TbInternsSearch";
            this.TbInternsSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbInternsSearch.OnValueChanged += new System.EventHandler(this.TbInternsSearch_OnValueChanged_1);
            // 
            // gvIntern
            // 
            this.gvIntern.AllowUserToAddRows = false;
            this.gvIntern.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvIntern.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.gvIntern, "gvIntern");
            this.gvIntern.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvIntern.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvIntern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvIntern.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvIntern.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvIntern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIntern.DoubleBuffered = true;
            this.gvIntern.EnableHeadersVisualStyles = false;
            this.gvIntern.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.gvIntern.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.gvIntern.MultiSelect = false;
            this.gvIntern.Name = "gvIntern";
            this.gvIntern.ReadOnly = true;
            this.gvIntern.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvIntern.RowHeadersVisible = false;
            this.gvIntern.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // WETp
            // 
            this.WETp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WETp.Controls.Add(this.TbWeekendSearch);
            this.WETp.Controls.Add(this.gvWeekend);
            this.WETp.Controls.Add(this.gunaCirclePictureBox4);
            resources.ApplyResources(this.WETp, "WETp");
            this.WETp.Name = "WETp";
            // 
            // TbWeekendSearch
            // 
            resources.ApplyResources(this.TbWeekendSearch, "TbWeekendSearch");
            this.TbWeekendSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbWeekendSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbWeekendSearch.HintForeColor = System.Drawing.Color.Empty;
            this.TbWeekendSearch.HintText = "ፈልግ";
            this.TbWeekendSearch.isPassword = false;
            this.TbWeekendSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbWeekendSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.TbWeekendSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.TbWeekendSearch.LineThickness = 3;
            this.TbWeekendSearch.Name = "TbWeekendSearch";
            this.TbWeekendSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbWeekendSearch.OnValueChanged += new System.EventHandler(this.TbWeekendSearch_OnValueChanged_1);
            // 
            // gvWeekend
            // 
            this.gvWeekend.AllowUserToAddRows = false;
            this.gvWeekend.AllowUserToDeleteRows = false;
            this.gvWeekend.AllowUserToResizeColumns = false;
            this.gvWeekend.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvWeekend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.gvWeekend, "gvWeekend");
            this.gvWeekend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvWeekend.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvWeekend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvWeekend.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWeekend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvWeekend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWeekend.DoubleBuffered = true;
            this.gvWeekend.EnableHeadersVisualStyles = false;
            this.gvWeekend.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.gvWeekend.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.gvWeekend.MultiSelect = false;
            this.gvWeekend.Name = "gvWeekend";
            this.gvWeekend.ReadOnly = true;
            this.gvWeekend.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvWeekend.RowHeadersVisible = false;
            this.gvWeekend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // gunaCirclePictureBox4
            // 
            resources.ApplyResources(this.gunaCirclePictureBox4, "gunaCirclePictureBox4");
            this.gunaCirclePictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox4.Image = global::Guest_Entry_Recording_System.Properties.Resources.search;
            this.gunaCirclePictureBox4.Name = "gunaCirclePictureBox4";
            this.gunaCirclePictureBox4.TabStop = false;
            this.gunaCirclePictureBox4.UseTransfarantBackground = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timUpdate
            // 
            this.timUpdate.Tick += new System.EventHandler(this.TimUpdate_Tick);
            // 
            // GuestsPedUc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GuestTc);
            this.Name = "GuestsPedUc";
            this.Load += new System.EventHandler(this.GuestsPedUc_Load);
            this.GuestTc.ResumeLayout(false);
            this.GuestInfoTp.ResumeLayout(false);
            this.GuestInfoTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrScannerPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuest)).EndInit();
            this.GunInfoTp.ResumeLayout(false);
            this.GunInfoTlp.ResumeLayout(false);
            this.GunInfoTlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.InternsTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIntern)).EndInit();
            this.WETp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvWeekend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvIntern;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbInternsSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbGunSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbGuestInfoSearch;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox3;
        public System.Windows.Forms.TabControl GuestTc;
        public System.Windows.Forms.TabPage GuestInfoTp;
        public System.Windows.Forms.TabPage GunInfoTp;
        public System.Windows.Forms.TabPage InternsTp;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbWeekendSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvWeekend;
        private Guna.UI.WinForms.GunaLabel GonLb;
        private System.Windows.Forms.TextBox tbSideNumber;
        private Guna.UI.WinForms.GunaLabel CoupLb;
        private Guna.UI.WinForms.GunaLabel SideNLb;
        private Guna.UI.WinForms.GunaLabel TogLb;
        private System.Windows.Forms.TextBox tbTypeOfGun;
        private System.Windows.Forms.TextBox tbCouponNumber;
        private System.Windows.Forms.TextBox tbGunOwner;
        public System.Windows.Forms.TableLayoutPanel GunInfoTlp;
        public System.Windows.Forms.TabPage WETp;
        public Guna.UI.WinForms.GunaAdvenceButton ClearBtn2;
        public Guna.UI.WinForms.GunaAdvenceButton btInsertGun;
        public Bunifu.Framework.UI.BunifuCustomDataGrid gvGuest;
        public Bunifu.Framework.UI.BunifuCustomDataGrid gvGun;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timUpdate;
        public System.Windows.Forms.ComboBox cboDevice;
        public System.Windows.Forms.Label CameraLb;
        public Guna.UI.WinForms.GunaAdvenceButton StartBtn;
        public System.Windows.Forms.PictureBox QrScannerPb;
        public Guna.UI.WinForms.GunaAdvenceButton StopBtn;
    }
}
