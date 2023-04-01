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
            this.dtpExpectedEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedEndTime = new System.Windows.Forms.Label();
            this.dtpExpectedStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedStartTime = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(157, 25);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(544, 26);
            this.tbTaskName.TabIndex = 1;
            // 
            // gbxTask
            // 
            this.gbxTask.Controls.Add(this.dtpExpectedEndTime);
            this.gbxTask.Controls.Add(this.lblExpectedEndTime);
            this.gbxTask.Controls.Add(this.dtpExpectedStartTime);
            this.gbxTask.Controls.Add(this.lblExpectedStartTime);
            this.gbxTask.Controls.Add(this.lblTaskName);
            this.gbxTask.Controls.Add(this.tbTaskName);
            this.gbxTask.Location = new System.Drawing.Point(12, 342);
            this.gbxTask.Name = "gbxTask";
            this.gbxTask.Size = new System.Drawing.Size(717, 269);
            this.gbxTask.TabIndex = 2;
            this.gbxTask.TabStop = false;
            this.gbxTask.Text = "Task";
            // 
            // dtpExpectedEndTime
            // 
            this.dtpExpectedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedEndTime.Location = new System.Drawing.Point(157, 88);
            this.dtpExpectedEndTime.Name = "dtpExpectedEndTime";
            this.dtpExpectedEndTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedEndTime.TabIndex = 18;
            // 
            // lblExpectedEndTime
            // 
            this.lblExpectedEndTime.AutoSize = true;
            this.lblExpectedEndTime.Location = new System.Drawing.Point(71, 93);
            this.lblExpectedEndTime.Name = "lblExpectedEndTime";
            this.lblExpectedEndTime.Size = new System.Drawing.Size(80, 20);
            this.lblExpectedEndTime.TabIndex = 17;
            this.lblExpectedEndTime.Text = "End Time:";
            // 
            // dtpExpectedStartTime
            // 
            this.dtpExpectedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedStartTime.Location = new System.Drawing.Point(157, 57);
            this.dtpExpectedStartTime.Name = "dtpExpectedStartTime";
            this.dtpExpectedStartTime.Size = new System.Drawing.Size(119, 26);
            this.dtpExpectedStartTime.TabIndex = 14;
            // 
            // lblExpectedStartTime
            // 
            this.lblExpectedStartTime.AutoSize = true;
            this.lblExpectedStartTime.Location = new System.Drawing.Point(65, 62);
            this.lblExpectedStartTime.Name = "lblExpectedStartTime";
            this.lblExpectedStartTime.Size = new System.Drawing.Size(86, 20);
            this.lblExpectedStartTime.TabIndex = 13;
            this.lblExpectedStartTime.Text = "Start Time:";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(62, 28);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(89, 20);
            this.lblTaskName.TabIndex = 2;
            this.lblTaskName.Text = "Task Name";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(735, 131);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(97, 32);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(735, 169);
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
            this.dgvTasks.Size = new System.Drawing.Size(717, 324);
            this.dgvTasks.TabIndex = 5;
            // 
            // EditTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 623);
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
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.DateTimePicker dtpExpectedEndTime;
        private System.Windows.Forms.Label lblExpectedEndTime;
        private System.Windows.Forms.DateTimePicker dtpExpectedStartTime;
        private System.Windows.Forms.Label lblExpectedStartTime;
        private System.Windows.Forms.DataGridView dgvTasks;
    }
}