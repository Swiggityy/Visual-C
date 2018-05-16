namespace VacationGetaways
{
    partial class DiagnoseFile
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
            this.lblForEmail = new System.Windows.Forms.Label();
            this.lblFileEmailFound = new System.Windows.Forms.Label();
            this.lblForFirstName = new System.Windows.Forms.Label();
            this.lblFileNameFound = new System.Windows.Forms.Label();
            this.lblForLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblForPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileIndex = new System.Windows.Forms.Label();
            this.lblToShowFileIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForEmail
            // 
            this.lblForEmail.AutoSize = true;
            this.lblForEmail.Location = new System.Drawing.Point(52, 141);
            this.lblForEmail.Name = "lblForEmail";
            this.lblForEmail.Size = new System.Drawing.Size(112, 17);
            this.lblForEmail.TabIndex = 0;
            this.lblForEmail.Text = "File Email Found";
            // 
            // lblFileEmailFound
            // 
            this.lblFileEmailFound.AutoSize = true;
            this.lblFileEmailFound.Location = new System.Drawing.Point(213, 141);
            this.lblFileEmailFound.Name = "lblFileEmailFound";
            this.lblFileEmailFound.Size = new System.Drawing.Size(46, 17);
            this.lblFileEmailFound.TabIndex = 1;
            this.lblFileEmailFound.Text = "label1";
            // 
            // lblForFirstName
            // 
            this.lblForFirstName.AutoSize = true;
            this.lblForFirstName.Location = new System.Drawing.Point(52, 79);
            this.lblForFirstName.Name = "lblForFirstName";
            this.lblForFirstName.Size = new System.Drawing.Size(150, 17);
            this.lblForFirstName.TabIndex = 2;
            this.lblForFirstName.Text = "File First Name Found:";
            // 
            // lblFileNameFound
            // 
            this.lblFileNameFound.AutoSize = true;
            this.lblFileNameFound.Location = new System.Drawing.Point(213, 79);
            this.lblFileNameFound.Name = "lblFileNameFound";
            this.lblFileNameFound.Size = new System.Drawing.Size(46, 17);
            this.lblFileNameFound.TabIndex = 3;
            this.lblFileNameFound.Text = "label2";
            // 
            // lblForLastName
            // 
            this.lblForLastName.AutoSize = true;
            this.lblForLastName.Location = new System.Drawing.Point(52, 110);
            this.lblForLastName.Name = "lblForLastName";
            this.lblForLastName.Size = new System.Drawing.Size(146, 17);
            this.lblForLastName.TabIndex = 4;
            this.lblForLastName.Text = "File Last Name Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // lblForPassword
            // 
            this.lblForPassword.AutoSize = true;
            this.lblForPassword.Location = new System.Drawing.Point(52, 174);
            this.lblForPassword.Name = "lblForPassword";
            this.lblForPassword.Size = new System.Drawing.Size(139, 17);
            this.lblForPassword.TabIndex = 6;
            this.lblForPassword.Text = "File Password Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // lblFileIndex
            // 
            this.lblFileIndex.AutoSize = true;
            this.lblFileIndex.Location = new System.Drawing.Point(55, 28);
            this.lblFileIndex.Name = "lblFileIndex";
            this.lblFileIndex.Size = new System.Drawing.Size(121, 17);
            this.lblFileIndex.TabIndex = 8;
            this.lblFileIndex.Text = "File Index Number";
            // 
            // lblToShowFileIndex
            // 
            this.lblToShowFileIndex.AutoSize = true;
            this.lblToShowFileIndex.Location = new System.Drawing.Point(213, 28);
            this.lblToShowFileIndex.Name = "lblToShowFileIndex";
            this.lblToShowFileIndex.Size = new System.Drawing.Size(46, 17);
            this.lblToShowFileIndex.TabIndex = 9;
            this.lblToShowFileIndex.Text = "label4";
            // 
            // DiagnoseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 296);
            this.Controls.Add(this.lblToShowFileIndex);
            this.Controls.Add(this.lblFileIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblForPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblForLastName);
            this.Controls.Add(this.lblFileNameFound);
            this.Controls.Add(this.lblForFirstName);
            this.Controls.Add(this.lblFileEmailFound);
            this.Controls.Add(this.lblForEmail);
            this.Name = "DiagnoseFile";
            this.Text = "DiagnoseFile";
            this.Load += new System.EventHandler(this.DiagnoseFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForEmail;
        private System.Windows.Forms.Label lblFileEmailFound;
        private System.Windows.Forms.Label lblForFirstName;
        private System.Windows.Forms.Label lblFileNameFound;
        private System.Windows.Forms.Label lblForLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblForPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileIndex;
        private System.Windows.Forms.Label lblToShowFileIndex;
    }
}