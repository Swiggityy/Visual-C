namespace Customers
{
    partial class ArrayForm
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
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(50, 67);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(168, 130);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "label1";
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResults);
            this.Name = "ArrayForm";
            this.Text = "ArrayForm";
            this.Load += new System.EventHandler(this.ArrayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
    }
}