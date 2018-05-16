namespace WindowsFormsApp2
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.Label();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.txtCreateUsername = new System.Windows.Forms.Label();
            this.textBoxCreateUsername = new System.Windows.Forms.TextBox();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnRecord2 = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.textBoxPayRate = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.labelPayRate = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.btnRecord3 = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(297, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(170, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Enter Your Name";
            // 
            // txtMajor
            // 
            this.txtMajor.AutoSize = true;
            this.txtMajor.Location = new System.Drawing.Point(171, 113);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(86, 13);
            this.txtMajor.TabIndex = 10;
            this.txtMajor.Text = "Enter Your Major";
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Enabled = false;
            this.textBoxMajor.Location = new System.Drawing.Point(297, 113);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMajor.TabIndex = 2;
            this.textBoxMajor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.AutoSize = true;
            this.txtCreateUsername.Location = new System.Drawing.Point(170, 198);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(89, 13);
            this.txtCreateUsername.TabIndex = 4;
            this.txtCreateUsername.Text = "Create Username";
            // 
            // textBoxCreateUsername
            // 
            this.textBoxCreateUsername.Enabled = false;
            this.textBoxCreateUsername.Location = new System.Drawing.Point(297, 198);
            this.textBoxCreateUsername.Name = "textBoxCreateUsername";
            this.textBoxCreateUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreateUsername.TabIndex = 4;
            this.textBoxCreateUsername.TextChanged += new System.EventHandler(this.textBoxCreateUsername_TextChanged);
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Enabled = false;
            this.textBoxCreatePassword.Location = new System.Drawing.Point(297, 243);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreatePassword.TabIndex = 5;
            this.textBoxCreatePassword.TextChanged += new System.EventHandler(this.textBoxCreatePassword_TextChanged);
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.AutoSize = true;
            this.txtCreatePassword.Location = new System.Drawing.Point(171, 243);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(87, 13);
            this.txtCreatePassword.TabIndex = 7;
            this.txtCreatePassword.Text = "Create Password";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(306, 33);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(82, 20);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Welcome";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(297, 145);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Press to Enter";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Visible = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnRecord2
            // 
            this.btnRecord2.Location = new System.Drawing.Point(297, 269);
            this.btnRecord2.Name = "btnRecord2";
            this.btnRecord2.Size = new System.Drawing.Size(100, 23);
            this.btnRecord2.TabIndex = 6;
            this.btnRecord2.Text = "Press to Enter";
            this.btnRecord2.UseVisualStyleBackColor = true;
            this.btnRecord2.Visible = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(301, 175);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(0, 13);
            this.lblConfirm.TabIndex = 11;
            // 
            // textBoxPayRate
            // 
            this.textBoxPayRate.Location = new System.Drawing.Point(297, 337);
            this.textBoxPayRate.Name = "textBoxPayRate";
            this.textBoxPayRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxPayRate.TabIndex = 12;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(297, 373);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 20);
            this.textBoxHours.TabIndex = 13;
            this.textBoxHours.TextChanged += new System.EventHandler(this.textBoxHours_TextChanged);
            // 
            // labelPayRate
            // 
            this.labelPayRate.AutoSize = true;
            this.labelPayRate.Location = new System.Drawing.Point(172, 337);
            this.labelPayRate.Name = "labelPayRate";
            this.labelPayRate.Size = new System.Drawing.Size(91, 13);
            this.labelPayRate.TabIndex = 14;
            this.labelPayRate.Text = "Enter Hourly Rate";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(172, 373);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(104, 13);
            this.labelHours.TabIndex = 15;
            this.labelHours.Text = "Enter Hours Worked";
            // 
            // btnRecord3
            // 
            this.btnRecord3.Location = new System.Drawing.Point(297, 410);
            this.btnRecord3.Name = "btnRecord3";
            this.btnRecord3.Size = new System.Drawing.Size(100, 23);
            this.btnRecord3.TabIndex = 16;
            this.btnRecord3.Text = "Press to Calculate";
            this.btnRecord3.UseVisualStyleBackColor = true;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(301, 437);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 13);
            this.labelResults.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 472);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.btnRecord3);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelPayRate);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxPayRate);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.btnRecord2);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.textBoxCreatePassword);
            this.Controls.Add(this.textBoxCreateUsername);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtMajor;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.Label txtCreateUsername;
        private System.Windows.Forms.TextBox textBoxCreateUsername;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Label txtCreatePassword;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnRecord2;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox textBoxPayRate;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label labelPayRate;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button btnRecord3;
        private System.Windows.Forms.Label labelResults;
    }
}

