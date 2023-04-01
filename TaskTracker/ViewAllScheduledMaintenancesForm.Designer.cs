namespace TaskTracker
{
    partial class ViewAllScheduledMaintenancesForm
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
            this.lbxAllScheduledMaintenances = new System.Windows.Forms.ListBox();
            this.btnDeleteScheduledMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAllScheduledMaintenances
            // 
            this.lbxAllScheduledMaintenances.FormattingEnabled = true;
            this.lbxAllScheduledMaintenances.ItemHeight = 20;
            this.lbxAllScheduledMaintenances.Location = new System.Drawing.Point(12, 12);
            this.lbxAllScheduledMaintenances.Name = "lbxAllScheduledMaintenances";
            this.lbxAllScheduledMaintenances.Size = new System.Drawing.Size(134, 84);
            this.lbxAllScheduledMaintenances.TabIndex = 1;
            // 
            // btnDeleteScheduledMaintenance
            // 
            this.btnDeleteScheduledMaintenance.Location = new System.Drawing.Point(152, 12);
            this.btnDeleteScheduledMaintenance.Name = "btnDeleteScheduledMaintenance";
            this.btnDeleteScheduledMaintenance.Size = new System.Drawing.Size(203, 56);
            this.btnDeleteScheduledMaintenance.TabIndex = 20;
            this.btnDeleteScheduledMaintenance.Text = "Delete Scheduled Maintenance";
            this.btnDeleteScheduledMaintenance.UseVisualStyleBackColor = true;
            this.btnDeleteScheduledMaintenance.Click += new System.EventHandler(this.BtnDeleteScheduledMaintenance_Click);
            // 
            // ViewAllScheduledMaintenancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 625);
            this.Controls.Add(this.btnDeleteScheduledMaintenance);
            this.Controls.Add(this.lbxAllScheduledMaintenances);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAllScheduledMaintenancesForm";
            this.Text = "All Scheduled Maintenances";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxAllScheduledMaintenances;
        private System.Windows.Forms.Button btnDeleteScheduledMaintenance;
    }
}