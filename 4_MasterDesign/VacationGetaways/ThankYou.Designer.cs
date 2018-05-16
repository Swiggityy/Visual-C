namespace VacationGetaways
{
    partial class ThankYou
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
            this.lblThanks = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(55, 68);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(201, 13);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "Thank you for Booking with Vacaytions!  ";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 133);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(143, 23);
            this.btnHome.TabIndex = 56;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnPast
            // 
            this.btnPast.Location = new System.Drawing.Point(163, 133);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(143, 23);
            this.btnPast.TabIndex = 55;
            this.btnPast.Text = "View Past Trips";
            this.btnPast.UseVisualStyleBackColor = true;
            // 
            // ThankYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 168);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.lblThanks);
            this.Name = "ThankYou";
            this.Text = "ThankYou";
            this.Load += new System.EventHandler(this.ThankYou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPast;
    }
}