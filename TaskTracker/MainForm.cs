using DataAccessLibrary;
using DataAccessLibrary.Models;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskTracker
{
    public partial class MainForm : Form
    {
        public ScheduledMaintenance scheduledMaintenance = null;
        public List<ScheduledMaintenance> scheduledMaintenances = new List<ScheduledMaintenance>();

        JSONFileDataAccess jsonFileDataAccess = new JSONFileDataAccess();
        string dataFilePath = "scheduled-maintenance-data.json";

        TimeSpan elapsedTime = TimeSpan.Zero;
        Timer elapsedTimeTimer = new Timer();

        string dateTimeStringFormat = "M/d/yyyy h:mm tt";

        public MainForm()
        {
            InitializeComponent();

            SetCurrentDateTimeLabel();

            InitializeCurrentDateTimeTimer();
            
            LoadScheduledMaintenancesFromFile();

            if (scheduledMaintenance != null)
            {
                PopulateScheduledMaintenanceStatusLabels();
                RefreshDataGridView();
            }

            ConditionallyEnableTaskButtons();
            RenderStartEndScheduledMaintenanceButton();
            ConditionallyEnableDeleteButton();
        }

        private void ConditionallyEnableTaskButtons()
        {
            if (scheduledMaintenance != null)
            {
                if (scheduledMaintenance.ActualStartDateTime != null)
                {
                    btnEditTasks.Enabled = false;
                    btnStartTask.Enabled = true;
                    btnCompleteTask.Enabled = true;
                    btnMarkIssue.Enabled = true;
                }
                else
                {
                    btnEditTasks.Enabled = true;
                    btnStartTask.Enabled = false;
                    btnCompleteTask.Enabled = false;
                    btnMarkIssue.Enabled = false;
                }
            }
        }

        private void RenderStartEndScheduledMaintenanceButton()
        {
            if (scheduledMaintenance != null)
            {
                if (scheduledMaintenance.ActualStartDateTime == null)
                {
                    btnStartEndScheduledMaintenance.Text = "Start Scheduled Maintenance";
                    btnStartEndScheduledMaintenance.Enabled = true;
                }
                else if (scheduledMaintenance.ActualStartDateTime != null && scheduledMaintenance.ActualEndDateTime == null)
                {
                    btnStartEndScheduledMaintenance.Text = "End Scheduled Maintenance";
                    btnStartEndScheduledMaintenance.Enabled = true;
                }
                else if (scheduledMaintenance.ActualEndDateTime != null)
                {
                    btnStartEndScheduledMaintenance.Text = "End Scheduled Maintenance";
                    btnStartEndScheduledMaintenance.Enabled = false;
                }
            }
            else
            {
                btnStartEndScheduledMaintenance.Enabled = false;
            }
        }

        private void ConditionallyEnableDeleteButton()
        {
            if (scheduledMaintenance != null)
            {
                btnDeleteScheduledMaintenance.Enabled = true;
            }
        }

        public void RefreshDataGridView()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = scheduledMaintenance.Tasks;
            SharedMethods.FormatDataGridView(dgvTasks);
        }

        private void PopulateScheduledMaintenanceStatusLabels()
        {
            if (scheduledMaintenance.ScheduledStartDateTime != null)
            {
                lblScheduledStartDateTime.Text = scheduledMaintenance.ScheduledStartDateTime?.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ScheduledEndDateTime != null)
            {
                lblScheduledEndDateTime.Text = scheduledMaintenance.ScheduledEndDateTime?.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ActualStartDateTime != null)
            {
                lblActualStartDateTime.Text = scheduledMaintenance.ActualStartDateTime?.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ActualEndDateTime != null)
            {
                lblActualEndDateTime.Text = scheduledMaintenance.ActualEndDateTime?.ToString(dateTimeStringFormat);
            }
        }

        private void InitializeCurrentDateTimeTimer()
        {
            Timer currentDateTimeTimer = new Timer();
            currentDateTimeTimer.Interval = (1 * 1000); // 1 second
            currentDateTimeTimer.Tick += new EventHandler(CurrentDateTimeTimer_Tick);
            currentDateTimeTimer.Start();
        }

        private void InitializeElapsedTimeTimer()
        {
            elapsedTimeTimer.Interval = (950); // 0.95 seconds; less than 1 second to keep it updating every second
            elapsedTimeTimer.Tick += new EventHandler(ElapsedTimeTimer_Tick);
            elapsedTimeTimer.Start();
        }

        private void SetCurrentDateTimeLabel()
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString(dateTimeStringFormat);
        }

        private void SetElapsedTimeLabel()
        {
            elapsedTime = (TimeSpan)(DateTime.Now - scheduledMaintenance.ActualStartDateTime);
            lblElapsedTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        public void SaveScheduledMaintenancesToFile()
        {
            jsonFileDataAccess.WriteAllScheduledMaintenances(scheduledMaintenances, dataFilePath);
        }

        private void LoadScheduledMaintenancesFromFile()
        {
            if (File.Exists(dataFilePath))
            {
                scheduledMaintenances = jsonFileDataAccess.ReadAllScheduledMaintenances(dataFilePath);
                if (scheduledMaintenances.Count != 0)
                {
                    scheduledMaintenance = scheduledMaintenances[0];
                }
            }
        }

        private void CurrentDateTimeTimer_Tick(object sender, EventArgs e)
        {
            SetCurrentDateTimeLabel();
        }

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            SetElapsedTimeLabel();
        }

        private void ClearStatus()
        {
            string labelText = "<empty>";

            lblElapsedTime.Text = labelText;
            lblScheduledStartDateTime.Text = labelText;
            lblActualStartDateTime.Text = labelText;
            lblScheduledEndDateTime.Text = labelText;
            lblActualEndDateTime.Text = labelText;
        }

        private void BtnEditTasks_Click(object sender, EventArgs e)
        {
            EditTasksForm editTasksForm = new EditTasksForm(this);
            editTasksForm.ShowDialog();
        }

        private void BtnStartEndScheduledMaintenance_Click(object sender, EventArgs e)
        {
            if (btnStartEndScheduledMaintenance.Text == "Start Scheduled Maintenance")
            {
                scheduledMaintenance.ActualStartDateTime = DateTime.Now;
                lblActualStartDateTime.Text = scheduledMaintenance.ActualStartDateTime?.ToString(dateTimeStringFormat);
                InitializeElapsedTimeTimer();
                SaveScheduledMaintenancesToFile();
                ConditionallyEnableTaskButtons();
                btnStartEndScheduledMaintenance.Text = "End Scheduled Maintenance";
            }
            else if (btnStartEndScheduledMaintenance.Text == "End Scheduled Maintenance")
            {
                scheduledMaintenance.ActualEndDateTime = DateTime.Now;
                lblActualEndDateTime.Text = scheduledMaintenance.ActualEndDateTime?.ToString(dateTimeStringFormat);
                elapsedTimeTimer.Stop();
                SaveScheduledMaintenancesToFile();
                ConditionallyEnableTaskButtons();
                btnStartEndScheduledMaintenance.Enabled = false;
            }
        }

        private void BtnEditScheduledMaintenance_Click(object sender, EventArgs e)
        {
            EditScheduledMaintenanceForm editScheduledMaintenanceForm = new EditScheduledMaintenanceForm(this);
            editScheduledMaintenanceForm.ShowDialog();
        }

        private void BtnViewAllScheduledMaintenances_Click(object sender, EventArgs e)
        {
            ViewAllScheduledMaintenancesForm viewAllScheduledMaintenancesForm = new ViewAllScheduledMaintenancesForm(this);
            viewAllScheduledMaintenancesForm.ShowDialog();
        }

        private void BtnNewScheduledMaintenance_Click(object sender, EventArgs e)
        {
            scheduledMaintenance = new ScheduledMaintenance();
            scheduledMaintenances.Add(scheduledMaintenance);
            ClearStatus();

            ConditionallyEnableDeleteButton();
            ConditionallyEnableTaskButtons();
            RenderStartEndScheduledMaintenanceButton();

            EditScheduledMaintenanceForm editScheduledMaintenanceForm = new EditScheduledMaintenanceForm(this);
            editScheduledMaintenanceForm.ShowDialog();
        }

        private void BtnDeleteScheduledMaintenance_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Delete this scheduled maintenance?",
                                    "Proceed?",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation);
            if (confirmResult == DialogResult.Yes)
            {
                scheduledMaintenances.Remove(scheduledMaintenance);
                scheduledMaintenance = null;
                SaveScheduledMaintenancesToFile();
                ClearStatus();

                ConditionallyEnableDeleteButton();
                ConditionallyEnableTaskButtons();
                RenderStartEndScheduledMaintenanceButton();

                dgvTasks.DataSource = null;
            }
        }

        private void BtnStartTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 1)
            {
                ScheduledMaintenanceTask task = (ScheduledMaintenanceTask)dgvTasks.CurrentRow.DataBoundItem;
                task.ActualStartDateTime = DateTime.Now;
                task.Status = Enums.ScheduledMaintenanceTaskStatus.InProgress;
                SaveScheduledMaintenancesToFile();
                RefreshDataGridView();

                var lblDescription = new Label();
                lblDescription.Text = task.Description;
                lblDescription.AutoSize = true;
                lblDescription.Anchor = AnchorStyles.Right;
                tlpCurrentTasks.Controls.Add(lblDescription);
                var progressBar = new System.Windows.Forms.ProgressBar();
                progressBar.Style = ProgressBarStyle.Marquee;
                tlpCurrentTasks.Controls.Add(progressBar);
                tlpCurrentTasks.RowCount++;
            }
        }

        private void BtnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 1)
            {
                ScheduledMaintenanceTask task = (ScheduledMaintenanceTask)dgvTasks.CurrentRow.DataBoundItem;
                task.ActualEndDateTime = DateTime.Now;
                task.Status = Enums.ScheduledMaintenanceTaskStatus.Complete;
                SaveScheduledMaintenancesToFile();
                RefreshDataGridView();
            }
        }

        private void BtnMarkIssue_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 1)
            {
                ScheduledMaintenanceTask task = (ScheduledMaintenanceTask)dgvTasks.CurrentRow.DataBoundItem;
                task.ActualEndDateTime = DateTime.Now;
                task.Status = Enums.ScheduledMaintenanceTaskStatus.Issue;
                SaveScheduledMaintenancesToFile();
                RefreshDataGridView();
            }
        }
    }
}
