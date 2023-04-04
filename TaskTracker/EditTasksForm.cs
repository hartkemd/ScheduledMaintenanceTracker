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

            dtpScheduledStartTime.ShowUpDown = true;
            dtpScheduledEndTime.ShowUpDown = true;

            dtpScheduledStartTime.Value = (DateTime)(_mainForm.scheduledMaintenance.ScheduledStartDateTime?.Date +
                _mainForm.scheduledMaintenance.ScheduledStartDateTime?.TimeOfDay);
            dtpScheduledEndTime.Value = dtpScheduledStartTime.Value;
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
            SharedMethods.FormatDataGridView(dgvTasks);
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            ScheduledMaintenanceTask task = new ScheduledMaintenanceTask();
            task.Description = tbDescription.Text;
            task.OwnershipGroup = cbOwnershipGroup.SelectedItem.ToString();
            task.ScheduledStartDateTime = dtpScheduledStartTime.Value;
            task.ScheduledEndDateTime = dtpScheduledEndTime.Value;
            _mainForm.scheduledMaintenance.Tasks.Add(task);
            _mainForm.SaveScheduledMaintenancesToFile();
            tbDescription.Text = "";
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
                _mainForm.RefreshDataGridView();
            }
        }

        private void BtnEditOwnershipGroups_Click(object sender, EventArgs e)
        {
            EditOwnershipGroupsForm editOwnershipGroups = new EditOwnershipGroupsForm(this);
            editOwnershipGroups.ShowDialog();
        }

        private void DtpExpectedStartTime_ValueChanged(object sender, EventArgs e)
        {
            if (btnSave.Visible == false)
            {
                dtpScheduledEndTime.Value = dtpScheduledStartTime.Value;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 1)
            {
                ScheduledMaintenanceTask task = (ScheduledMaintenanceTask)dgvTasks.CurrentRow.DataBoundItem;
                tbDescription.Text = task.Description;
                cbOwnershipGroup.SelectedItem = task.OwnershipGroup;
                dtpScheduledStartTime.Value = (DateTime)task.ScheduledStartDateTime;
                dtpScheduledEndTime.Value = (DateTime)task.ScheduledEndDateTime;

                btnSave.Visible = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ScheduledMaintenanceTask task = (ScheduledMaintenanceTask)dgvTasks.CurrentRow.DataBoundItem;
            task.Description = tbDescription.Text;
            task.OwnershipGroup = cbOwnershipGroup.SelectedItem.ToString();
            task.ScheduledStartDateTime = dtpScheduledStartTime.Value;
            task.ScheduledEndDateTime = dtpScheduledEndTime.Value;
            _mainForm.SaveScheduledMaintenancesToFile();
            tbDescription.Text = "";
            cbOwnershipGroup.SelectedIndex = 0;
            RefreshDataGridView();
            _mainForm.RefreshDataGridView();
        }
    }
}
