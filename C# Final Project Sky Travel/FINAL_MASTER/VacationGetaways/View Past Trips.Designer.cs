namespace VacationGetaways
{
    partial class frmViewPastTrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPastTrips));
            this.lblViewPastTrips1 = new System.Windows.Forms.Label();
            this.lblViewPastTrip2 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.listPastTrips = new System.Windows.Forms.ListView();
            this.colHeadTripDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTripDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNumPeople = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAirFare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadHotelCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewTripDetails = new System.Windows.Forms.Button();
            this.lblNoTripsFound = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewPastTrips1
            // 
            this.lblViewPastTrips1.AutoSize = true;
            this.lblViewPastTrips1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPastTrips1.Location = new System.Drawing.Point(235, 18);
            this.lblViewPastTrips1.Name = "lblViewPastTrips1";
            this.lblViewPastTrips1.Size = new System.Drawing.Size(386, 42);
            this.lblViewPastTrips1.TabIndex = 16;
            this.lblViewPastTrips1.Text = "View Past Trips for User: ";
            // 
            // lblViewPastTrip2
            // 
            this.lblViewPastTrip2.AutoSize = true;
            this.lblViewPastTrip2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPastTrip2.ForeColor = System.Drawing.Color.Blue;
            this.lblViewPastTrip2.Location = new System.Drawing.Point(316, 58);
            this.lblViewPastTrip2.Name = "lblViewPastTrip2";
            this.lblViewPastTrip2.Size = new System.Drawing.Size(0, 27);
            this.lblViewPastTrip2.TabIndex = 18;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(261, 117);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 17);
            this.lblFirstName.TabIndex = 19;
            // 
            // listPastTrips
            // 
            this.listPastTrips.BackColor = System.Drawing.Color.LightCyan;
            this.listPastTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadTripDate,
            this.colHeadTripDest,
            this.colHeadNumPeople,
            this.colHeadAirFare,
            this.colHeadHotelCost});
            this.listPastTrips.GridLines = true;
            this.listPastTrips.Location = new System.Drawing.Point(0, 142);
            this.listPastTrips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPastTrips.Name = "listPastTrips";
            this.listPastTrips.Size = new System.Drawing.Size(701, 318);
            this.listPastTrips.TabIndex = 20;
            this.listPastTrips.UseCompatibleStateImageBehavior = false;
            this.listPastTrips.View = System.Windows.Forms.View.Details;
            this.listPastTrips.SelectedIndexChanged += new System.EventHandler(this.listPastTrips_SelectedIndexChanged);
            // 
            // colHeadTripDate
            // 
            this.colHeadTripDate.Text = "Date of Booking";
            this.colHeadTripDate.Width = 128;
            // 
            // colHeadTripDest
            // 
            this.colHeadTripDest.Text = "Trip Destination";
            this.colHeadTripDest.Width = 100;
            // 
            // colHeadNumPeople
            // 
            this.colHeadNumPeople.Text = "Travelers";
            this.colHeadNumPeople.Width = 70;
            // 
            // colHeadAirFare
            // 
            this.colHeadAirFare.Text = "Airfare";
            // 
            // colHeadHotelCost
            // 
            this.colHeadHotelCost.Text = "Hotel Cost";
            this.colHeadHotelCost.Width = 70;
            // 
            // btnViewTripDetails
            // 
            this.btnViewTripDetails.BackColor = System.Drawing.Color.LightCyan;
            this.btnViewTripDetails.Enabled = false;
            this.btnViewTripDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTripDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTripDetails.ForeColor = System.Drawing.Color.LightCoral;
            this.btnViewTripDetails.Location = new System.Drawing.Point(532, 114);
            this.btnViewTripDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewTripDetails.Name = "btnViewTripDetails";
            this.btnViewTripDetails.Size = new System.Drawing.Size(168, 30);
            this.btnViewTripDetails.TabIndex = 21;
            this.btnViewTripDetails.Text = "View Trip Details";
            this.btnViewTripDetails.UseVisualStyleBackColor = false;
            this.btnViewTripDetails.Click += new System.EventHandler(this.btnViewTripDetails_Click);
            // 
            // lblNoTripsFound
            // 
            this.lblNoTripsFound.AutoSize = true;
            this.lblNoTripsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTripsFound.ForeColor = System.Drawing.Color.Red;
            this.lblNoTripsFound.Location = new System.Drawing.Point(261, 101);
            this.lblNoTripsFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoTripsFound.Name = "lblNoTripsFound";
            this.lblNoTripsFound.Size = new System.Drawing.Size(0, 17);
            this.lblNoTripsFound.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VacationGetaways.Properties.Resources.Globe;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // frmViewPastTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(706, 467);
            this.Controls.Add(this.lblNoTripsFound);
            this.Controls.Add(this.btnViewTripDetails);
            this.Controls.Add(this.listPastTrips);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblViewPastTrip2);
            this.Controls.Add(this.lblViewPastTrips1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(724, 514);
            this.MinimumSize = new System.Drawing.Size(724, 514);
            this.Name = "frmViewPastTrips";
            this.Text = "View_Past_Trips";
            this.Load += new System.EventHandler(this.frmViewPastTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblViewPastTrips1;
        private System.Windows.Forms.Label lblViewPastTrip2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ListView listPastTrips;
        private System.Windows.Forms.ColumnHeader colHeadTripDest;
        private System.Windows.Forms.ColumnHeader colHeadNumPeople;
        private System.Windows.Forms.ColumnHeader colHeadAirFare;
        private System.Windows.Forms.ColumnHeader colHeadHotelCost;
        private System.Windows.Forms.ColumnHeader colHeadTripDate;
        private System.Windows.Forms.Button btnViewTripDetails;
        private System.Windows.Forms.Label lblNoTripsFound;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}