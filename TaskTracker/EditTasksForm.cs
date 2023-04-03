using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskTracker
{
    public partial class EditTasksForm : Form
    {
        private MainForm _mainForm;
        public List<string> ownershipGroups = new List<string>();

        JSONFileDataAccess jsonFileDataAccess = new JSONFileDataAccess();
        string dataFilePath = "ownership-group-data.json";

        public EditTasksForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();

            RefreshDataGridView();

            LoadOwnershipGroupsFromFile();
            cbOwnershipGroup.DataSource = ownershipGroups;

            dtpExpectedStartTime.ShowUpDown = true;
            dtpExpectedEndTime.ShowUpDown = true;

            dtpExpectedStartTime.Value = _mainForm.scheduledMaintenance.ScheduledStartDateTime.Date +
                _mainForm.scheduledMaintenance.ScheduledStartDateTime.TimeOfDay;
            dtpExpectedEndTime.Value = dtpExpectedStartTime.Value;
        }

        public void RefreshOwnershipGroupsComboBox()
        {
            cbOwnershipGroup.DataSource = null;
            cbOwnershipGroup.DataSource = ownershipGroups;
        }

        public void SaveOwnershipGroupsToFile()
        {
            jsonFileDataAccess.WriteAllOwnershipGroups(ownershipGroups, dataFilePath);
        }

        private void LoadOwnershipGroupsFromFile()
        {
            if (File.Exists(dataFilePath))
            {
                ownershipGroups = jsonFileDataAccess.ReadAllOwnershipGroups(dataFilePath);
            }
        }

        private void RefreshDataGridView()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _mainForm.scheduledMaintenance.Tasks;
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgvTasks.Columns[2].Visible = false;
            dgvTasks.Columns[5].Visible = false;
            dgvTasks.Columns[6].Visible = false;
            dgvTasks.Columns[3].DefaultCellStyle.Format = "h:mm tt";
            dgvTasks.Columns[4].DefaultCellStyle.Format = "h:mm tt";
            dgvTasks.Columns[1].HeaderText = "Ownership Group";
            dgvTasks.Columns[3].HeaderText = "Start Time";
            dgvTasks.Columns[4].HeaderText = "End Time";
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            ScheduledMaintenanceTask task = new ScheduledMaintenanceTask();
            task.Description = tbTaskName.Text;
            task.OwnershipGroup = cbOwnershipGroup.SelectedItem.ToString();
            task.ScheduledStartDateTime = dtpExpectedStartTime.Value;
            task.ScheduledEndDateTime = dtpExpectedEndTime.Value;
            _mainForm.scheduledMaintenance.Tasks.Add(task);
            _mainForm.SaveScheduledMaintenancesToFile();
            tbTaskName.Text = "";
            cbOwnershipGroup.SelectedIndex = 0;
            RefreshDataGridView();
            _mainForm.RefreshDataGridView();
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                _mainForm.scheduledMaintenance.Tasks.RemoveAt(dgvTasks.SelectedRows[0].Index);
                _mainForm.SaveScheduledMaintenancesToFile();
                RefreshDataGridView();
            }
        }

        private void BtnEditOwnershipGroups_Click(object sender, EventArgs e)
        {
            EditOwnershipGroupsForm editOwnershipGroups = new EditOwnershipGroupsForm(this);
            editOwnershipGroups.ShowDialog();
        }

        private void DtpExpectedStartTime_ValueChanged(object sender, EventArgs e)
        {
            dtpExpectedEndTime.Value = dtpExpectedStartTime.Value;
        }
    }
}
