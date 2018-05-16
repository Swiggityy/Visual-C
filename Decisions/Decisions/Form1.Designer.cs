namespace WindowsFormsApp1
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
            this.lblEnterBirthMonth = new System.Windows.Forms.Label();
            this.txtBoxMonth = new System.Windows.Forms.TextBox();
            this.btnBirthMonth = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterBirthMonth
            // 
            this.lblEnterBirthMonth.AutoSize = true;
            this.lblEnterBirthMonth.Location = new System.Drawing.Point(160, 76);
            this.lblEnterBirthMonth.Name = "lblEnterBirthMonth";
            this.lblEnterBirthMonth.Size = new System.Drawing.Size(159, 13);
            this.lblEnterBirthMonth.TabIndex = 0;
            this.lblEnterBirthMonth.Text = "Enter Your Birth Month as a digit";
            // 
            // txtBoxMonth
            // 
            this.txtBoxMonth.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMonth.Location = new System.Drawing.Point(185, 92);
            this.txtBoxMonth.Name = "txtBoxMonth";
            this.txtBoxMonth.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMonth.TabIndex = 1;
            // 
            // btnBirthMonth
            // 
            this.btnBirthMonth.Location = new System.Drawing.Point(197, 118);
            this.btnBirthMonth.Name = "btnBirthMonth";
            this.btnBirthMonth.Size = new System.Drawing.Size(75, 23);
            this.btnBirthMonth.TabIndex = 2;
            this.btnBirthMonth.Text = "Enter";
            this.btnBirthMonth.UseVisualStyleBackColor = true;
            this.btnBirthMonth.Click += new System.EventHandler(this.btnBirthMonth_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(221, 197);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 390);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBirthMonth);
            this.Controls.Add(this.txtBoxMonth);
            this.Controls.Add(this.lblEnterBirthMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterBirthMonth;
        private System.Windows.Forms.TextBox txtBoxMonth;
        private System.Windows.Forms.Button btnBirthMonth;
        private System.Windows.Forms.Label lblResult;
    }
}

