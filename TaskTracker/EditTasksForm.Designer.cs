namespace TaskTracker
{
    partial class EditTasksForm
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
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.gbxTask = new System.Windows.Forms.GroupBox();
            this.btnEditOwnershipGroups = new System.Windows.Forms.Button();
            this.cbOwnershipGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpExpectedEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedEndTime = new System.Windows.Forms.Label();
            this.dtpExpectedStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedStartTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(190, 25);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(498, 26);
            this.tbTaskName.TabIndex = 1;
            // 
            // gbxTask
            // 
            this.gbxTask.Controls.Add(this.btnEditOwnershipGroups);
            this.gbxTask.Controls.Add(this.cbOwnershipGroup);
            this.gbxTask.Controls.Add(this.label1);
            this.gbxTask.Controls.Add(this.dtpExpectedEndTime);
            this.gbxTask.Controls.Add(this.lblExpectedEndTime);
            this.gbxTask.Controls.Add(this.dtpExpectedStartTime);
            this.gbxTask.Controls.Add(this.lblExpectedStartTime);
            this.gbxTask.Controls.Add(this.lblDescription);
            this.gbxTask.Controls.Add(this.tbTaskName);
            this.gbxTask.Location = new System.Drawing.Point(12, 352);
            this.gbxTask.Name = "gbxTask";
            this.gbxTask.Size = new System.Drawing.Size(764, 269);
            this.gbxTask.TabIndex = 2;
            this.gbxTask.TabStop = false;
            this.gbxTask.Text = "Task";
            // 
            // btnEditOwnershipGroups
            // 
            this.btnEditOwnershipGroups.Location = new System.Drawing.Point(448, 65);
            this.btnEditOwnershipGroups.Name = "btnEditOwnershipGroups";
            this.btnEditOwnershipGroups.Size = new System.Drawing.Size(57, 28);
            this.btnEditOwnershipGroups.TabIndex = 21;
            this.btnEditOwnershipGroups.Text = "Edit";
            this.btnEditOwnershipGroups.UseVisualStyleBackColor = true;
            this.btnEditOwnershipGroups.Click += new System.EventHandler(this.BtnEditOwnershipGroups_Click);
            // 
            // cbOwnershipGroup
            // 
            this.cbOwnershipGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOwnershipGroup.FormattingEnabled = true;
            this.cbOwnershipGroup.Location = new System.Drawing.Point(190, 65);
            this.cbOwnershipGroup.Name = "cbOwnershipGroup";
            this.cbOwnershipGroup.Size = new System.Drawing.Size(252, 28);
            this.cbOwnershipGroup.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ownership Group";
            // 
            // dtpExpectedEndTime
            // 
            this.dtpExpectedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedEndTime.Location = new System.Drawing.Point(190, 137);
            this.dtpExpectedEndTime.Name = "dtpExpectedEndTime";
            this.dtpExpectedEndTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedEndTime.TabIndex = 18;
            // 
            // lblExpectedEndTime
            // 
            this.lblExpectedEndTime.AutoSize = true;
            this.lblExpectedEndTime.Location = new System.Drawing.Point(104, 142);
            this.lblExpectedEndTime.Name = "lblExpectedEndTime";
            this.lblExpectedEndTime.Size = new System.Drawing.Size(80, 20);
            this.lblExpectedEndTime.TabIndex = 17;
            this.lblExpectedEndTime.Text = "End Time:";
            // 
            // dtpExpectedStartTime
            // 
            this.dtpExpectedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedStartTime.Location = new System.Drawing.Point(190, 106);
            this.dtpExpectedStartTime.Name = "dtpExpectedStartTime";
            this.dtpExpectedStartTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedStartTime.TabIndex = 14;
            this.dtpExpectedStartTime.ValueChanged += new System.EventHandler(this.DtpExpectedStartTime_ValueChanged);
            // 
            // lblExpectedStartTime
            // 
            this.lblExpectedStartTime.AutoSize = true;
            this.lblExpectedStartTime.Location = new System.Drawing.Point(98, 111);
            this.lblExpectedStartTime.Name = "lblExpectedStartTime";
            this.lblExpectedStartTime.Size = new System.Drawing.Size(86, 20);
            this.lblExpectedStartTime.TabIndex = 13;
            this.lblExpectedStartTime.Text = "Start Time:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(95, 28);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(782, 147);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(97, 32);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(782, 185);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(97, 32);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
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
            this.dgvTasks.Location = new System.Drawing.Point(12, 12);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(764, 334);
            this.dgvTasks.TabIndex = 7;
            // 
            // EditTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.gbxTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditTasksForm";
            this.Text = "Edit Tasks";
            this.gbxTask.ResumeLayout(false);
            this.gbxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.GroupBox gbxTask;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.DateTimePicker dtpExpectedEndTime;
        private System.Windows.Forms.Label lblExpectedEndTime;
        private System.Windows.Forms.DateTimePicker dtpExpectedStartTime;
        private System.Windows.Forms.Label lblExpectedStartTime;
        private System.Windows.Forms.ComboBox cbOwnershipGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditOwnershipGroups;
        private System.Windows.Forms.DataGridView dgvTasks;
    }
}