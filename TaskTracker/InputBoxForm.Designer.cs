namespace TaskTracker
{
    partial class InputBoxForm
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
            this.lblDescribeTheIssue = new System.Windows.Forms.Label();
            this.tbIssueDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescribeTheIssue
            // 
            this.lblDescribeTheIssue.AutoSize = true;
            this.lblDescribeTheIssue.Location = new System.Drawing.Point(12, 9);
            this.lblDescribeTheIssue.Name = "lblDescribeTheIssue";
            this.lblDescribeTheIssue.Size = new System.Drawing.Size(140, 20);
            this.lblDescribeTheIssue.TabIndex = 0;
            this.lblDescribeTheIssue.Text = "Describe the issue";
            // 
            // tbIssueDescription
            // 
            this.tbIssueDescription.Location = new System.Drawing.Point(16, 32);
            this.tbIssueDescription.Name = "tbIssueDescription";
            this.tbIssueDescription.Size = new System.Drawing.Size(624, 26);
            this.tbIssueDescription.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(284, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 37);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // InputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 143);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbIssueDescription);
            this.Controls.Add(this.lblDescribeTheIssue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InputBoxForm";
            this.Text = "Describe Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescribeTheIssue;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox tbIssueDescription;
    }
}