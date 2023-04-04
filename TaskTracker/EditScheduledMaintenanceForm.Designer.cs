namespace TaskTracker
{
    partial class EditScheduledMaintenanceForm
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
            this.lblExpectedStartDate = new System.Windows.Forms.Label();
            this.dtpExpectedStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpectedStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedStartTime = new System.Windows.Forms.Label();
            this.dtpExpectedEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedEndTime = new System.Windows.Forms.Label();
            this.dtpExpectedEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedEndDate = new System.Windows.Forms.Label();
            this.gbxScheduledStartAndEnd = new System.Windows.Forms.GroupBox();
            this.gbxScheduledStartAndEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpectedStartDate
            // 
            this.lblExpectedStartDate.AutoSize = true;
            this.lblExpectedStartDate.Location = new System.Drawing.Point(64, 72);
            this.lblExpectedStartDate.Name = "lblExpectedStartDate";
            this.lblExpectedStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblExpectedStartDate.TabIndex = 0;
            this.lblExpectedStartDate.Text = "Start Date:";
            // 
            // dtpExpectedStartDate
            // 
            this.dtpExpectedStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedStartDate.Location = new System.Drawing.Point(157, 67);
            this.dtpExpectedStartDate.Name = "dtpExpectedStartDate";
            this.dtpExpectedStartDate.Size = new System.Drawing.Size(219, 26);
            this.dtpExpectedStartDate.TabIndex = 1;
            this.dtpExpectedStartDate.ValueChanged += new System.EventHandler(this.DtpExpectedStartDate_ValueChanged);
            // 
            // dtpExpectedStartTime
            // 
            this.dtpExpectedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedStartTime.Location = new System.Drawing.Point(542, 67);
            this.dtpExpectedStartTime.Name = "dtpExpectedStartTime";
            this.dtpExpectedStartTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedStartTime.TabIndex = 2;
            // 
            // lblExpectedStartTime
            // 
            this.lblExpectedStartTime.AutoSize = true;
            this.lblExpectedStartTime.Location = new System.Drawing.Point(450, 72);
            this.lblExpectedStartTime.Name = "lblExpectedStartTime";
            this.lblExpectedStartTime.Size = new System.Drawing.Size(86, 20);
            this.lblExpectedStartTime.TabIndex = 2;
            this.lblExpectedStartTime.Text = "Start Time:";
            // 
            // dtpExpectedEndTime
            // 
            this.dtpExpectedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedEndTime.Location = new System.Drawing.Point(542, 117);
            this.dtpExpectedEndTime.Name = "dtpExpectedEndTime";
            this.dtpExpectedEndTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedEndTime.TabIndex = 4;
            // 
            // lblExpectedEndTime
            // 
            this.lblExpectedEndTime.AutoSize = true;
            this.lblExpectedEndTime.Location = new System.Drawing.Point(456, 122);
            this.lblExpectedEndTime.Name = "lblExpectedEndTime";
            this.lblExpectedEndTime.Size = new System.Drawing.Size(80, 20);
            this.lblExpectedEndTime.TabIndex = 7;
            this.lblExpectedEndTime.Text = "End Time:";
            // 
            // dtpExpectedEndDate
            // 
            this.dtpExpectedEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedEndDate.Location = new System.Drawing.Point(157, 118);
            this.dtpExpectedEndDate.Name = "dtpExpectedEndDate";
            this.dtpExpectedEndDate.Size = new System.Drawing.Size(219, 26);
            this.dtpExpectedEndDate.TabIndex = 3;
            // 
            // lblExpectedEndDate
            // 
            this.lblExpectedEndDate.AutoSize = true;
            this.lblExpectedEndDate.Location = new System.Drawing.Point(70, 123);
            this.lblExpectedEndDate.Name = "lblExpectedEndDate";
            this.lblExpectedEndDate.Size = new System.Drawing.Size(81, 20);
            this.lblExpectedEndDate.TabIndex = 5;
            this.lblExpectedEndDate.Text = "End Date:";
            // 
            // gbxScheduledStartAndEnd
            // 
            this.gbxScheduledStartAndEnd.Controls.Add(this.dtpExpectedStartTime);
            this.gbxScheduledStartAndEnd.Controls.Add(this.dtpExpectedEndTime);
            this.gbxScheduledStartAndEnd.Controls.Add(this.lblExpectedStartDate);
            this.gbxScheduledStartAndEnd.Controls.Add(this.lblExpectedEndTime);
            this.gbxScheduledStartAndEnd.Controls.Add(this.dtpExpectedStartDate);
            this.gbxScheduledStartAndEnd.Controls.Add(this.dtpExpectedEndDate);
            this.gbxScheduledStartAndEnd.Controls.Add(this.lblExpectedStartTime);
            this.gbxScheduledStartAndEnd.Controls.Add(this.lblExpectedEndDate);
            this.gbxScheduledStartAndEnd.Location = new System.Drawing.Point(13, 13);
            this.gbxScheduledStartAndEnd.Name = "gbxScheduledStartAndEnd";
            this.gbxScheduledStartAndEnd.Size = new System.Drawing.Size(814, 190);
            this.gbxScheduledStartAndEnd.TabIndex = 9;
            this.gbxScheduledStartAndEnd.TabStop = false;
            this.gbxScheduledStartAndEnd.Text = "Scheduled Start and End";
            // 
            // EditScheduledMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 621);
            this.Controls.Add(this.gbxScheduledStartAndEnd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditScheduledMaintenanceForm";
            this.Text = "Edit Scheduled Maintenance";
            this.gbxScheduledStartAndEnd.ResumeLayout(false);
            this.gbxScheduledStartAndEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpectedStartDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedStartDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedStartTime;
        private System.Windows.Forms.Label lblExpectedStartTime;
        private System.Windows.Forms.DateTimePicker dtpExpectedEndTime;
        private System.Windows.Forms.Label lblExpectedEndTime;
        private System.Windows.Forms.DateTimePicker dtpExpectedEndDate;
        private System.Windows.Forms.Label lblExpectedEndDate;
        private System.Windows.Forms.GroupBox gbxScheduledStartAndEnd;
    }
}