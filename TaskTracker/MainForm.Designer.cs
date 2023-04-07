namespace TaskTracker
{
    partial class MainForm
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
            this.lblLabelCurrentDateTime = new System.Windows.Forms.Label();
            this.btnEditTasks = new System.Windows.Forms.Button();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.lblLabelScheduledStartDateTime = new System.Windows.Forms.Label();
            this.lblScheduledStartDateTime = new System.Windows.Forms.Label();
            this.lblScheduledEndDateTime = new System.Windows.Forms.Label();
            this.lblLabelScheduledEndDateTime = new System.Windows.Forms.Label();
            this.lblActualStartDateTime = new System.Windows.Forms.Label();
            this.lblLabelActualStartDateTime = new System.Windows.Forms.Label();
            this.lblActualEndDateTime = new System.Windows.Forms.Label();
            this.lblLabelActualEndDateTime = new System.Windows.Forms.Label();
            this.gbxAllTasks = new System.Windows.Forms.GroupBox();
            this.btnMarkIssue = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbxCurrentTasks = new System.Windows.Forms.GroupBox();
            this.gbxScheduledMaintenanceStatus = new System.Windows.Forms.GroupBox();
            this.lblLabelElapsedTime = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.btnStartEndScheduledMaintenance = new System.Windows.Forms.Button();
            this.btnEditScheduledMaintenance = new System.Windows.Forms.Button();
            this.gbxScheduledMaintenanceCrud = new System.Windows.Forms.GroupBox();
            this.btnDeleteScheduledMaintenance = new System.Windows.Forms.Button();
            this.btnViewPastScheduledMaintenances = new System.Windows.Forms.Button();
            this.btnNewScheduledMaintenance = new System.Windows.Forms.Button();
            this.tlpCurrentTasks = new System.Windows.Forms.TableLayoutPanel();
            this.gbxAllTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbxCurrentTasks.SuspendLayout();
            this.gbxScheduledMaintenanceStatus.SuspendLayout();
            this.gbxScheduledMaintenanceCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLabelCurrentDateTime
            // 
            this.lblLabelCurrentDateTime.AutoSize = true;
            this.lblLabelCurrentDateTime.Location = new System.Drawing.Point(27, 36);
            this.lblLabelCurrentDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelCurrentDateTime.Name = "lblLabelCurrentDateTime";
            this.lblLabelCurrentDateTime.Size = new System.Drawing.Size(143, 20);
            this.lblLabelCurrentDateTime.TabIndex = 1;
            this.lblLabelCurrentDateTime.Text = "Current Date/Time:";
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Location = new System.Drawing.Point(7, 367);
            this.btnEditTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Size = new System.Drawing.Size(112, 35);
            this.btnEditTasks.TabIndex = 2;
            this.btnEditTasks.Text = "Edit Tasks";
            this.btnEditTasks.UseVisualStyleBackColor = true;
            this.btnEditTasks.Click += new System.EventHandler(this.BtnEditTasks_Click);
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(178, 36);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(70, 20);
            this.lblCurrentDateTime.TabIndex = 3;
            this.lblCurrentDateTime.Text = "<empty>";
            // 
            // lblLabelScheduledStartDateTime
            // 
            this.lblLabelScheduledStartDateTime.AutoSize = true;
            this.lblLabelScheduledStartDateTime.Location = new System.Drawing.Point(42, 94);
            this.lblLabelScheduledStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelScheduledStartDateTime.Name = "lblLabelScheduledStartDateTime";
            this.lblLabelScheduledStartDateTime.Size = new System.Drawing.Size(128, 20);
            this.lblLabelScheduledStartDateTime.TabIndex = 4;
            this.lblLabelScheduledStartDateTime.Text = "Scheduled Start:";
            // 
            // lblScheduledStartDateTime
            // 
            this.lblScheduledStartDateTime.AutoSize = true;
            this.lblScheduledStartDateTime.Location = new System.Drawing.Point(178, 94);
            this.lblScheduledStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduledStartDateTime.Name = "lblScheduledStartDateTime";
            this.lblScheduledStartDateTime.Size = new System.Drawing.Size(70, 20);
            this.lblScheduledStartDateTime.TabIndex = 5;
            this.lblScheduledStartDateTime.Text = "<empty>";
            // 
            // lblScheduledEndDateTime
            // 
            this.lblScheduledEndDateTime.AutoSize = true;
            this.lblScheduledEndDateTime.Location = new System.Drawing.Point(178, 153);
            this.lblScheduledEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduledEndDateTime.Name = "lblScheduledEndDateTime";
            this.lblScheduledEndDateTime.Size = new System.Drawing.Size(70, 20);
            this.lblScheduledEndDateTime.TabIndex = 7;
            this.lblScheduledEndDateTime.Text = "<empty>";
            // 
            // lblLabelScheduledEndDateTime
            // 
            this.lblLabelScheduledEndDateTime.AutoSize = true;
            this.lblLabelScheduledEndDateTime.Location = new System.Drawing.Point(48, 153);
            this.lblLabelScheduledEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelScheduledEndDateTime.Name = "lblLabelScheduledEndDateTime";
            this.lblLabelScheduledEndDateTime.Size = new System.Drawing.Size(122, 20);
            this.lblLabelScheduledEndDateTime.TabIndex = 6;
            this.lblLabelScheduledEndDateTime.Text = "Scheduled End:";
            // 
            // lblActualStartDateTime
            // 
            this.lblActualStartDateTime.AutoSize = true;
            this.lblActualStartDateTime.Location = new System.Drawing.Point(178, 124);
            this.lblActualStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualStartDateTime.Name = "lblActualStartDateTime";
            this.lblActualStartDateTime.Size = new System.Drawing.Size(70, 20);
            this.lblActualStartDateTime.TabIndex = 9;
            this.lblActualStartDateTime.Text = "<empty>";
            // 
            // lblLabelActualStartDateTime
            // 
            this.lblLabelActualStartDateTime.AutoSize = true;
            this.lblLabelActualStartDateTime.Location = new System.Drawing.Point(73, 124);
            this.lblLabelActualStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelActualStartDateTime.Name = "lblLabelActualStartDateTime";
            this.lblLabelActualStartDateTime.Size = new System.Drawing.Size(97, 20);
            this.lblLabelActualStartDateTime.TabIndex = 8;
            this.lblLabelActualStartDateTime.Text = "Actual Start:";
            // 
            // lblActualEndDateTime
            // 
            this.lblActualEndDateTime.AutoSize = true;
            this.lblActualEndDateTime.Location = new System.Drawing.Point(178, 185);
            this.lblActualEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualEndDateTime.Name = "lblActualEndDateTime";
            this.lblActualEndDateTime.Size = new System.Drawing.Size(70, 20);
            this.lblActualEndDateTime.TabIndex = 11;
            this.lblActualEndDateTime.Text = "<empty>";
            // 
            // lblLabelActualEndDateTime
            // 
            this.lblLabelActualEndDateTime.AutoSize = true;
            this.lblLabelActualEndDateTime.Location = new System.Drawing.Point(79, 185);
            this.lblLabelActualEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelActualEndDateTime.Name = "lblLabelActualEndDateTime";
            this.lblLabelActualEndDateTime.Size = new System.Drawing.Size(91, 20);
            this.lblLabelActualEndDateTime.TabIndex = 10;
            this.lblLabelActualEndDateTime.Text = "Actual End:";
            // 
            // gbxAllTasks
            // 
            this.gbxAllTasks.Controls.Add(this.btnMarkIssue);
            this.gbxAllTasks.Controls.Add(this.btnCompleteTask);
            this.gbxAllTasks.Controls.Add(this.btnStartTask);
            this.gbxAllTasks.Controls.Add(this.dgvTasks);
            this.gbxAllTasks.Controls.Add(this.btnEditTasks);
            this.gbxAllTasks.Location = new System.Drawing.Point(12, 12);
            this.gbxAllTasks.Name = "gbxAllTasks";
            this.gbxAllTasks.Size = new System.Drawing.Size(1170, 410);
            this.gbxAllTasks.TabIndex = 12;
            this.gbxAllTasks.TabStop = false;
            this.gbxAllTasks.Text = "All Tasks";
            // 
            // btnMarkIssue
            // 
            this.btnMarkIssue.Enabled = false;
            this.btnMarkIssue.Location = new System.Drawing.Point(394, 367);
            this.btnMarkIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMarkIssue.Name = "btnMarkIssue";
            this.btnMarkIssue.Size = new System.Drawing.Size(119, 35);
            this.btnMarkIssue.TabIndex = 5;
            this.btnMarkIssue.Text = "Mark Issue";
            this.btnMarkIssue.UseVisualStyleBackColor = true;
            this.btnMarkIssue.Click += new System.EventHandler(this.BtnMarkIssue_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Enabled = false;
            this.btnCompleteTask.Location = new System.Drawing.Point(247, 367);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(139, 35);
            this.btnCompleteTask.TabIndex = 4;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.BtnCompleteTask_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Location = new System.Drawing.Point(127, 367);
            this.btnStartTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(112, 35);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "Start Task";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.BtnStartTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(7, 25);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(1157, 334);
            this.dgvTasks.StandardTab = true;
            this.dgvTasks.TabIndex = 1;
            // 
            // gbxCurrentTasks
            // 
            this.gbxCurrentTasks.Controls.Add(this.tlpCurrentTasks);
            this.gbxCurrentTasks.Location = new System.Drawing.Point(12, 428);
            this.gbxCurrentTasks.Name = "gbxCurrentTasks";
            this.gbxCurrentTasks.Size = new System.Drawing.Size(1170, 346);
            this.gbxCurrentTasks.TabIndex = 13;
            this.gbxCurrentTasks.TabStop = false;
            this.gbxCurrentTasks.Text = "Current Tasks";
            // 
            // gbxScheduledMaintenanceStatus
            // 
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelElapsedTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblElapsedTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelCurrentDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblCurrentDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelScheduledStartDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblActualEndDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblScheduledStartDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelActualEndDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelScheduledEndDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblActualStartDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblScheduledEndDateTime);
            this.gbxScheduledMaintenanceStatus.Controls.Add(this.lblLabelActualStartDateTime);
            this.gbxScheduledMaintenanceStatus.Location = new System.Drawing.Point(1188, 12);
            this.gbxScheduledMaintenanceStatus.Name = "gbxScheduledMaintenanceStatus";
            this.gbxScheduledMaintenanceStatus.Size = new System.Drawing.Size(422, 231);
            this.gbxScheduledMaintenanceStatus.TabIndex = 14;
            this.gbxScheduledMaintenanceStatus.TabStop = false;
            this.gbxScheduledMaintenanceStatus.Text = "Scheduled Maintenance Status";
            // 
            // lblLabelElapsedTime
            // 
            this.lblLabelElapsedTime.AutoSize = true;
            this.lblLabelElapsedTime.Location = new System.Drawing.Point(61, 65);
            this.lblLabelElapsedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabelElapsedTime.Name = "lblLabelElapsedTime";
            this.lblLabelElapsedTime.Size = new System.Drawing.Size(109, 20);
            this.lblLabelElapsedTime.TabIndex = 12;
            this.lblLabelElapsedTime.Text = "Elapsed Time:";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(178, 65);
            this.lblElapsedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(70, 20);
            this.lblElapsedTime.TabIndex = 13;
            this.lblElapsedTime.Text = "<empty>";
            // 
            // btnStartEndScheduledMaintenance
            // 
            this.btnStartEndScheduledMaintenance.Location = new System.Drawing.Point(1284, 249);
            this.btnStartEndScheduledMaintenance.Name = "btnStartEndScheduledMaintenance";
            this.btnStartEndScheduledMaintenance.Size = new System.Drawing.Size(203, 56);
            this.btnStartEndScheduledMaintenance.TabIndex = 7;
            this.btnStartEndScheduledMaintenance.Text = "Start Scheduled Maintenance";
            this.btnStartEndScheduledMaintenance.UseVisualStyleBackColor = true;
            this.btnStartEndScheduledMaintenance.Click += new System.EventHandler(this.BtnStartEndScheduledMaintenance_Click);
            // 
            // btnEditScheduledMaintenance
            // 
            this.btnEditScheduledMaintenance.Location = new System.Drawing.Point(6, 87);
            this.btnEditScheduledMaintenance.Name = "btnEditScheduledMaintenance";
            this.btnEditScheduledMaintenance.Size = new System.Drawing.Size(203, 56);
            this.btnEditScheduledMaintenance.TabIndex = 5;
            this.btnEditScheduledMaintenance.Text = "Edit This Scheduled Maintenance";
            this.btnEditScheduledMaintenance.UseVisualStyleBackColor = true;
            this.btnEditScheduledMaintenance.Click += new System.EventHandler(this.BtnEditScheduledMaintenance_Click);
            // 
            // gbxScheduledMaintenanceCrud
            // 
            this.gbxScheduledMaintenanceCrud.Controls.Add(this.btnDeleteScheduledMaintenance);
            this.gbxScheduledMaintenanceCrud.Controls.Add(this.btnViewPastScheduledMaintenances);
            this.gbxScheduledMaintenanceCrud.Controls.Add(this.btnEditScheduledMaintenance);
            this.gbxScheduledMaintenanceCrud.Controls.Add(this.btnNewScheduledMaintenance);
            this.gbxScheduledMaintenanceCrud.Location = new System.Drawing.Point(1191, 428);
            this.gbxScheduledMaintenanceCrud.Name = "gbxScheduledMaintenanceCrud";
            this.gbxScheduledMaintenanceCrud.Size = new System.Drawing.Size(419, 346);
            this.gbxScheduledMaintenanceCrud.TabIndex = 18;
            this.gbxScheduledMaintenanceCrud.TabStop = false;
            this.gbxScheduledMaintenanceCrud.Text = "CRUD Operations";
            // 
            // btnDeleteScheduledMaintenance
            // 
            this.btnDeleteScheduledMaintenance.Enabled = false;
            this.btnDeleteScheduledMaintenance.Location = new System.Drawing.Point(216, 87);
            this.btnDeleteScheduledMaintenance.Name = "btnDeleteScheduledMaintenance";
            this.btnDeleteScheduledMaintenance.Size = new System.Drawing.Size(203, 56);
            this.btnDeleteScheduledMaintenance.TabIndex = 6;
            this.btnDeleteScheduledMaintenance.Text = "Delete This Scheduled Maintenance";
            this.btnDeleteScheduledMaintenance.UseVisualStyleBackColor = true;
            this.btnDeleteScheduledMaintenance.Click += new System.EventHandler(this.BtnDeleteScheduledMaintenance_Click);
            // 
            // btnViewPastScheduledMaintenances
            // 
            this.btnViewPastScheduledMaintenances.Location = new System.Drawing.Point(216, 25);
            this.btnViewPastScheduledMaintenances.Name = "btnViewPastScheduledMaintenances";
            this.btnViewPastScheduledMaintenances.Size = new System.Drawing.Size(203, 56);
            this.btnViewPastScheduledMaintenances.TabIndex = 4;
            this.btnViewPastScheduledMaintenances.Text = "View Past Scheduled Maintenances";
            this.btnViewPastScheduledMaintenances.UseVisualStyleBackColor = true;
            this.btnViewPastScheduledMaintenances.Click += new System.EventHandler(this.BtnViewAllScheduledMaintenances_Click);
            // 
            // btnNewScheduledMaintenance
            // 
            this.btnNewScheduledMaintenance.Location = new System.Drawing.Point(6, 25);
            this.btnNewScheduledMaintenance.Name = "btnNewScheduledMaintenance";
            this.btnNewScheduledMaintenance.Size = new System.Drawing.Size(203, 56);
            this.btnNewScheduledMaintenance.TabIndex = 3;
            this.btnNewScheduledMaintenance.Text = "New Scheduled Maintenance";
            this.btnNewScheduledMaintenance.UseVisualStyleBackColor = true;
            this.btnNewScheduledMaintenance.Click += new System.EventHandler(this.BtnNewScheduledMaintenance_Click);
            // 
            // tlpCurrentTasks
            // 
            this.tlpCurrentTasks.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCurrentTasks.ColumnCount = 2;
            this.tlpCurrentTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurrentTasks.Location = new System.Drawing.Point(3, 22);
            this.tlpCurrentTasks.Name = "tlpCurrentTasks";
            this.tlpCurrentTasks.RowCount = 2;
            this.tlpCurrentTasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentTasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentTasks.Size = new System.Drawing.Size(1164, 321);
            this.tlpCurrentTasks.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 786);
            this.Controls.Add(this.gbxScheduledMaintenanceCrud);
            this.Controls.Add(this.btnStartEndScheduledMaintenance);
            this.Controls.Add(this.gbxScheduledMaintenanceStatus);
            this.Controls.Add(this.gbxCurrentTasks);
            this.Controls.Add(this.gbxAllTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Scheduled Maintenance Tracker";
            this.gbxAllTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbxCurrentTasks.ResumeLayout(false);
            this.gbxScheduledMaintenanceStatus.ResumeLayout(false);
            this.gbxScheduledMaintenanceStatus.PerformLayout();
            this.gbxScheduledMaintenanceCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLabelCurrentDateTime;
        private System.Windows.Forms.Button btnEditTasks;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label lblLabelScheduledStartDateTime;
        private System.Windows.Forms.Label lblLabelScheduledEndDateTime;
        private System.Windows.Forms.Label lblActualStartDateTime;
        private System.Windows.Forms.Label lblLabelActualStartDateTime;
        private System.Windows.Forms.Label lblActualEndDateTime;
        private System.Windows.Forms.Label lblLabelActualEndDateTime;
        private System.Windows.Forms.GroupBox gbxAllTasks;
        private System.Windows.Forms.GroupBox gbxCurrentTasks;
        private System.Windows.Forms.GroupBox gbxScheduledMaintenanceStatus;
        private System.Windows.Forms.Button btnStartEndScheduledMaintenance;
        private System.Windows.Forms.Label lblLabelElapsedTime;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Button btnEditScheduledMaintenance;
        public System.Windows.Forms.Label lblScheduledStartDateTime;
        public System.Windows.Forms.Label lblScheduledEndDateTime;
        private System.Windows.Forms.GroupBox gbxScheduledMaintenanceCrud;
        private System.Windows.Forms.Button btnViewPastScheduledMaintenances;
        private System.Windows.Forms.Button btnNewScheduledMaintenance;
        private System.Windows.Forms.Button btnDeleteScheduledMaintenance;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnMarkIssue;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentTasks;
    }
}

