namespace VacationGetaways
{
    partial class WarningOnCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningOnCancel));
            this.btnBacktoNewAccount = new System.Windows.Forms.Button();
            this.btnBacktoTripSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picGlobe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBacktoNewAccount
            // 
            this.btnBacktoNewAccount.BackColor = System.Drawing.Color.LightCyan;
            this.btnBacktoNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoNewAccount.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBacktoNewAccount.Location = new System.Drawing.Point(476, 215);
            this.btnBacktoNewAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBacktoNewAccount.Name = "btnBacktoNewAccount";
            this.btnBacktoNewAccount.Size = new System.Drawing.Size(276, 46);
            this.btnBacktoNewAccount.TabIndex = 5;
            this.btnBacktoNewAccount.Text = "Back to Create New Account";
            this.btnBacktoNewAccount.UseVisualStyleBackColor = false;
            this.btnBacktoNewAccount.Click += new System.EventHandler(this.btnBacktoNewAccount_Click);
            // 
            // btnBacktoTripSelection
            // 
            this.btnBacktoTripSelection.BackColor = System.Drawing.Color.LightCyan;
            this.btnBacktoTripSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoTripSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoTripSelection.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBacktoTripSelection.Location = new System.Drawing.Point(476, 269);
            this.btnBacktoTripSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBacktoTripSelection.Name = "btnBacktoTripSelection";
            this.btnBacktoTripSelection.Size = new System.Drawing.Size(276, 42);
            this.btnBacktoTripSelection.TabIndex = 6;
            this.btnBacktoTripSelection.Text = "Back to Trip Selection";
            this.btnBacktoTripSelection.UseVisualStyleBackColor = false;
            this.btnBacktoTripSelection.Click += new System.EventHandler(this.btnBacktoTripSelection_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(425, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 144);
            this.label1.TabIndex = 7;
            this.label1.Text = "Are you sure you want to Cancel?\r\n\r\nYou will lose the data you entered if you Can" +
    "cel.";
            // 
            // picGlobe
            // 
            this.picGlobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGlobe.Image = global::VacationGetaways.Properties.Resources.Globe;
            this.picGlobe.Location = new System.Drawing.Point(0, 0);
            this.picGlobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGlobe.Name = "picGlobe";
            this.picGlobe.Size = new System.Drawing.Size(410, 345);
            this.picGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlobe.TabIndex = 98;
            this.picGlobe.TabStop = false;
            // 
            // WarningOnCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(814, 336);
            this.Controls.Add(this.picGlobe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacktoTripSelection);
            this.Controls.Add(this.btnBacktoNewAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(836, 392);
            this.Name = "WarningOnCancel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WarningOnCancel";
            this.Load += new System.EventHandler(this.WarningOnCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBacktoNewAccount;
        private System.Windows.Forms.Button btnBacktoTripSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGlobe;
    }
}