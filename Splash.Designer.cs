namespace Guest_Entry_Recording_System
{
    partial class Splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.ProgressPN2 = new System.Windows.Forms.Panel();
            this.ProgressPN1 = new System.Windows.Forms.Panel();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.YearLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ProgressPN2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressPN2
            // 
            this.ProgressPN2.BackColor = System.Drawing.Color.White;
            this.ProgressPN2.Controls.Add(this.ProgressPN1);
            this.ProgressPN2.Location = new System.Drawing.Point(-1, 290);
            this.ProgressPN2.Name = "ProgressPN2";
            this.ProgressPN2.Size = new System.Drawing.Size(716, 10);
            this.ProgressPN2.TabIndex = 2;
            // 
            // ProgressPN1
            // 
            this.ProgressPN1.BackColor = System.Drawing.Color.Coral;
            this.ProgressPN1.Location = new System.Drawing.Point(0, 0);
            this.ProgressPN1.Name = "ProgressPN1";
            this.ProgressPN1.Size = new System.Drawing.Size(82, 15);
            this.ProgressPN1.TabIndex = 0;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Enabled = true;
            this.ProgressTimer.Interval = 15;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // YearLb
            // 
            this.YearLb.AutoSize = true;
            this.YearLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.YearLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.YearLb.Location = new System.Drawing.Point(622, 266);
            this.YearLb.Name = "YearLb";
            this.YearLb.Size = new System.Drawing.Size(94, 17);
            this.YearLb.TabIndex = 6;
            this.YearLb.Text = "© 2022 AUY3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(328, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Version 1.0";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Guest_Entry_Recording_System.Properties.Resources.RotatingLogo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(446, 23);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(202, 202);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guest_Entry_Recording_System.Properties.Resources.splash;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 300);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearLb);
            this.Controls.Add(this.ProgressPN2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ProgressPN2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ProgressPN2;
        private System.Windows.Forms.Panel ProgressPN1;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Label YearLb;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}