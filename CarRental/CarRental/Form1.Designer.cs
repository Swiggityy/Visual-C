namespace CarRental
{
	partial class Form1
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
            this.rdBtnComp = new System.Windows.Forms.RadioButton();
            this.rdBtnMid = new System.Windows.Forms.RadioButton();
            this.rdBtnLux = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdBtnComp
            // 
            this.rdBtnComp.AutoSize = true;
            this.rdBtnComp.Location = new System.Drawing.Point(62, 129);
            this.rdBtnComp.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnComp.Name = "rdBtnComp";
            this.rdBtnComp.Size = new System.Drawing.Size(110, 21);
            this.rdBtnComp.TabIndex = 0;
            this.rdBtnComp.TabStop = true;
            this.rdBtnComp.Text = "Compact Car";
            this.rdBtnComp.UseVisualStyleBackColor = true;
            // 
            // rdBtnMid
            // 
            this.rdBtnMid.AutoSize = true;
            this.rdBtnMid.Location = new System.Drawing.Point(62, 157);
            this.rdBtnMid.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnMid.Name = "rdBtnMid";
            this.rdBtnMid.Size = new System.Drawing.Size(109, 21);
            this.rdBtnMid.TabIndex = 1;
            this.rdBtnMid.TabStop = true;
            this.rdBtnMid.Text = "Mid-Size Car";
            this.rdBtnMid.UseVisualStyleBackColor = true;
            // 
            // rdBtnLux
            // 
            this.rdBtnLux.AutoSize = true;
            this.rdBtnLux.Location = new System.Drawing.Point(62, 185);
            this.rdBtnLux.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnLux.Name = "rdBtnLux";
            this.rdBtnLux.Size = new System.Drawing.Size(97, 21);
            this.rdBtnLux.TabIndex = 2;
            this.rdBtnLux.TabStop = true;
            this.rdBtnLux.Text = "Luxury Car";
            this.rdBtnLux.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 41);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(116, 17);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Enter your age";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(12, 76);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(133, 17);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Enter rental days";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(39, 323);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(43, 239);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(135, 28);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate total";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(136, 38);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 22);
            this.txtAge.TabIndex = 7;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(149, 73);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(132, 22);
            this.txtDay.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::CarRental.Properties.Resources.Car_Keys_in_hand_300x200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(785, 524);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.rdBtnLux);
            this.Controls.Add(this.rdBtnMid);
            this.Controls.Add(this.rdBtnComp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rdBtnComp;
		private System.Windows.Forms.RadioButton rdBtnMid;
		private System.Windows.Forms.RadioButton rdBtnLux;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblDay;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtDay;
	}
}

