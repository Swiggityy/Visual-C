namespace VacationGetaways
{
    partial class WarningOnBack
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
            this.btnBacktoBooking = new System.Windows.Forms.Button();
            this.btnBacktoTripSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picGlobe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBacktoBooking
            // 
            this.btnBacktoBooking.BackColor = System.Drawing.Color.LightCyan;
            this.btnBacktoBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoBooking.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBacktoBooking.Location = new System.Drawing.Point(469, 223);
            this.btnBacktoBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBacktoBooking.Name = "btnBacktoBooking";
            this.btnBacktoBooking.Size = new System.Drawing.Size(276, 46);
            this.btnBacktoBooking.TabIndex = 1;
            this.btnBacktoBooking.Text = "Back to Booking";
            this.btnBacktoBooking.UseVisualStyleBackColor = false;
            this.btnBacktoBooking.Click += new System.EventHandler(this.btnBacktoBooking_Click);
            // 
            // btnBacktoTripSelection
            // 
            this.btnBacktoTripSelection.BackColor = System.Drawing.Color.LightCyan;
            this.btnBacktoTripSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoTripSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoTripSelection.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBacktoTripSelection.Location = new System.Drawing.Point(469, 277);
            this.btnBacktoTripSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBacktoTripSelection.Name = "btnBacktoTripSelection";
            this.btnBacktoTripSelection.Size = new System.Drawing.Size(276, 46);
            this.btnBacktoTripSelection.TabIndex = 2;
            this.btnBacktoTripSelection.Text = "Back to Trip Selection";
            this.btnBacktoTripSelection.UseVisualStyleBackColor = false;
            this.btnBacktoTripSelection.Click += new System.EventHandler(this.btnBacktoTripSelection_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(425, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 144);
            this.label1.TabIndex = 3;
            this.label1.Text = "Are you sure you want to go back before submitting?\r\n\r\nYou will lose the data you" +
    " entered if you go back to Trip Selection.";
            // 
            // picGlobe
            // 
            this.picGlobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGlobe.Image = global::VacationGetaways.Properties.Resources.Globe;
            this.picGlobe.Location = new System.Drawing.Point(-2, 0);
            this.picGlobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGlobe.Name = "picGlobe";
            this.picGlobe.Size = new System.Drawing.Size(410, 345);
            this.picGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlobe.TabIndex = 99;
            this.picGlobe.TabStop = false;
            // 
            // WarningOnBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(814, 336);
            this.Controls.Add(this.picGlobe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacktoTripSelection);
            this.Controls.Add(this.btnBacktoBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(836, 392);
            this.Name = "WarningOnBack";
            this.Text = "Warning on Back";
            this.Load += new System.EventHandler(this.WarningOnBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBacktoBooking;
        private System.Windows.Forms.Button btnBacktoTripSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGlobe;
    }
}