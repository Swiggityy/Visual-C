namespace VacationGetaways
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPastTrips = new System.Windows.Forms.Button();
            this.btnCelebration = new System.Windows.Forms.Button();
            this.btnRelaxing = new System.Windows.Forms.Button();
            this.btnCulture = new System.Windows.Forms.Button();
            this.picGlobe = new System.Windows.Forms.PictureBox();
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(15, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(596, 41);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Member Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPastTrips
            // 
            this.btnPastTrips.Location = new System.Drawing.Point(609, 7);
            this.btnPastTrips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPastTrips.Name = "btnPastTrips";
            this.btnPastTrips.Size = new System.Drawing.Size(129, 27);
            this.btnPastTrips.TabIndex = 2;
            this.btnPastTrips.Text = "View Past Trips";
            this.btnPastTrips.UseVisualStyleBackColor = true;
            this.btnPastTrips.Click += new System.EventHandler(this.btnPastTrips_Click);
            // 
            // btnCelebration
            // 
            this.btnCelebration.FlatAppearance.BorderSize = 0;
            this.btnCelebration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.btnCelebration.ForeColor = System.Drawing.Color.White;
            this.btnCelebration.Image = ((System.Drawing.Image)(resources.GetObject("btnCelebration.Image")));
            this.btnCelebration.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCelebration.Location = new System.Drawing.Point(636, 385);
            this.btnCelebration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCelebration.Name = "btnCelebration";
            this.btnCelebration.Size = new System.Drawing.Size(259, 123);
            this.btnCelebration.TabIndex = 9;
            this.btnCelebration.Text = "Celebration Trips";
            this.btnCelebration.UseVisualStyleBackColor = true;
            this.btnCelebration.Click += new System.EventHandler(this.btnCelebration_Click);
            // 
            // btnRelaxing
            // 
            this.btnRelaxing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.btnRelaxing.ForeColor = System.Drawing.Color.White;
            this.btnRelaxing.Image = ((System.Drawing.Image)(resources.GetObject("btnRelaxing.Image")));
            this.btnRelaxing.Location = new System.Drawing.Point(636, 273);
            this.btnRelaxing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelaxing.Name = "btnRelaxing";
            this.btnRelaxing.Size = new System.Drawing.Size(259, 118);
            this.btnRelaxing.TabIndex = 8;
            this.btnRelaxing.Text = "Relaxing Trips";
            this.btnRelaxing.UseVisualStyleBackColor = true;
            this.btnRelaxing.Click += new System.EventHandler(this.btnRelaxing_Click);
            // 
            // btnCulture
            // 
            this.btnCulture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.btnCulture.ForeColor = System.Drawing.Color.White;
            this.btnCulture.Image = ((System.Drawing.Image)(resources.GetObject("btnCulture.Image")));
            this.btnCulture.Location = new System.Drawing.Point(636, 159);
            this.btnCulture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCulture.Name = "btnCulture";
            this.btnCulture.Size = new System.Drawing.Size(259, 119);
            this.btnCulture.TabIndex = 7;
            this.btnCulture.Text = "Cultural Trips";
            this.btnCulture.UseVisualStyleBackColor = true;
            this.btnCulture.Click += new System.EventHandler(this.btnCulture_Click);
            // 
            // picGlobe
            // 
            this.picGlobe.BackgroundImage = global::VacationGetaways.Properties.Resources.Globe;
            this.picGlobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGlobe.Location = new System.Drawing.Point(1, 159);
            this.picGlobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGlobe.Name = "picGlobe";
            this.picGlobe.Size = new System.Drawing.Size(312, 348);
            this.picGlobe.TabIndex = 6;
            this.picGlobe.TabStop = false;
            this.picGlobe.Click += new System.EventHandler(this.picGlobe_Click);
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Location = new System.Drawing.Point(741, 41);
            this.btnCreateNewAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(153, 30);
            this.btnCreateNewAccount.TabIndex = 10;
            this.btnCreateNewAccount.Text = "Create New Account";
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.btnCreateNewAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(765, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 32);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "About Message";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCreateNewAccount);
            this.Controls.Add(this.btnCelebration);
            this.Controls.Add(this.btnRelaxing);
            this.Controls.Add(this.btnCulture);
            this.Controls.Add(this.picGlobe);
            this.Controls.Add(this.btnPastTrips);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmWelcome";
            this.Text = "Welcome to Vacay!";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPastTrips;
        private System.Windows.Forms.PictureBox picGlobe;
        private System.Windows.Forms.Button btnCulture;
        private System.Windows.Forms.Button btnRelaxing;
        private System.Windows.Forms.Button btnCelebration;
        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}

