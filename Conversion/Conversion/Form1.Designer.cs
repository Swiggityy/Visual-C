namespace Conversion
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
            this.lblInches = new System.Windows.Forms.Label();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.txtBoxInches = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCentimetersOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(355, 70);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(49, 17);
            this.lblInches.TabIndex = 0;
            this.lblInches.Text = "Inches";
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.AutoSize = true;
            this.lblCentimeters.Location = new System.Drawing.Point(338, 249);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(83, 17);
            this.lblCentimeters.TabIndex = 1;
            this.lblCentimeters.Text = "Centimeters";
            // 
            // txtBoxInches
            // 
            this.txtBoxInches.Location = new System.Drawing.Point(329, 126);
            this.txtBoxInches.Name = "txtBoxInches";
            this.txtBoxInches.Size = new System.Drawing.Size(100, 22);
            this.txtBoxInches.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert to Centimeters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCentimetersOutput
            // 
            this.lblCentimetersOutput.AutoSize = true;
            this.lblCentimetersOutput.Location = new System.Drawing.Point(264, 292);
            this.lblCentimetersOutput.Name = "lblCentimetersOutput";
            this.lblCentimetersOutput.Size = new System.Drawing.Size(0, 17);
            this.lblCentimetersOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 466);
            this.Controls.Add(this.lblCentimetersOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxInches);
            this.Controls.Add(this.lblCentimeters);
            this.Controls.Add(this.lblInches);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblCentimeters;
        private System.Windows.Forms.TextBox txtBoxInches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCentimetersOutput;
    }
}

