namespace Cards
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
            this.lblamount = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rdBtnYes = new System.Windows.Forms.RadioButton();
            this.rdBtnNo = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(12, 33);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(221, 13);
            this.lblamount.TabIndex = 1;
            this.lblamount.Text = "How many cards would you like to purchase?";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(12, 63);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(179, 13);
            this.lblMembership.TabIndex = 2;
            this.lblMembership.Text = "Are you a rewards program member?";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(263, 35);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // rdBtnYes
            // 
            this.rdBtnYes.AutoSize = true;
            this.rdBtnYes.Location = new System.Drawing.Point(263, 63);
            this.rdBtnYes.Name = "rdBtnYes";
            this.rdBtnYes.Size = new System.Drawing.Size(43, 17);
            this.rdBtnYes.TabIndex = 5;
            this.rdBtnYes.TabStop = true;
            this.rdBtnYes.Text = "Yes";
            this.rdBtnYes.UseVisualStyleBackColor = true;
            // 
            // rdBtnNo
            // 
            this.rdBtnNo.AutoSize = true;
            this.rdBtnNo.Location = new System.Drawing.Point(324, 63);
            this.rdBtnNo.Name = "rdBtnNo";
            this.rdBtnNo.Size = new System.Drawing.Size(39, 17);
            this.rdBtnNo.TabIndex = 6;
            this.rdBtnNo.TabStop = true;
            this.rdBtnNo.Text = "No";
            this.rdBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(231, 112);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(132, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate Total";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(191, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 254);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.rdBtnNo);
            this.Controls.Add(this.rdBtnYes);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.lblamount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rdBtnYes;
        private System.Windows.Forms.RadioButton rdBtnNo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTotal;
    }
}

