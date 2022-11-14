namespace Guest_Entry_Recording_System
{
    partial class MessageOnCars
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
            this.WelcomeLb = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // WelcomeLb
            // 
            this.WelcomeLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeLb.AutoSize = true;
            this.WelcomeLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.WelcomeLb.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.WelcomeLb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WelcomeLb.Location = new System.Drawing.Point(401, 241);
            this.WelcomeLb.Name = "WelcomeLb";
            this.WelcomeLb.Size = new System.Drawing.Size(392, 67);
            this.WelcomeLb.TabIndex = 2;
            this.WelcomeLb.Text = "Messages place";
            // 
            // MessageOnCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.WelcomeLb);
            this.Name = "MessageOnCars";
            this.Size = new System.Drawing.Size(1093, 658);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel WelcomeLb;
    }
}
