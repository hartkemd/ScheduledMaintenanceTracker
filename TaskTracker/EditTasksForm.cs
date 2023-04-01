using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskTracker
{
    public partial class EditTasksForm : Form
    {
        private MainForm _mainForm;

        public EditTasksForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();

            RefreshDataGridView();

            dtpExpectedStartTime.ShowUpDown = true;
            dtpExpectedEndTime.ShowUpDown = true;

            dtpExpectedStartTime.Value = _mainForm.scheduledMaintenance.ScheduledStartDateTime.Date +
                _mainForm.scheduledMaintenance.ScheduledStartDateTime.TimeOfDay;
            dtpExpectedEndTime.Value = dtpExpectedStartTime.Value.AddHours(1);
        }

        private void RefreshDataGridView()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _mainForm.scheduledMaintenance.Tasks;
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgvTasks.Columns[3].Visible = false;
            dgvTasks.Columns[4].Visible = false;
            dgvTasks.Columns[1].DefaultCellStyle.Format = "h:mm tt";
            dgvTasks.Columns[2].DefaultCellStyle.Format = "h:mm tt";
            dgvTasks.Columns[1].HeaderText = "Start Time";
            dgvTasks.Columns[2].HeaderText = "End Time";
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            ScheduledMaintenanceTask task = new ScheduledMaintenanceTask();
            task.Name = tbTaskName.Text;
            task.ExpectedStartDateTime = dtpExpectedStartTime.Value;
            task.ExpectedEndDateTime = dtpExpectedEndTime.Value;
            _mainForm.scheduledMaintenance.Tasks.Add(task);
            _mainForm.SaveScheduledMaintenancesToFile();
            tbTaskName.Text = "";
            RefreshDataGridView();
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            _mainForm.scheduledMaintenance.Tasks.RemoveAt(dgvTasks.SelectedRows[0].Index);
            _mainForm.SaveScheduledMaintenancesToFile();
            RefreshDataGridView();
        }
    }
}
