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

namespace TaskTracker
{
    public partial class MainForm : Form
    {
        public ScheduledMaintenance scheduledMaintenance = new ScheduledMaintenance();
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
            PopulateLabels();
            ConditionallyEnableDeleteButton();
        }

        private void PopulateLabels()
        {
            if (scheduledMaintenance.ScheduledStartDateTime != DateTime.MinValue)
            {
                lblScheduledStartDateTime.Text = scheduledMaintenance.ScheduledStartDateTime.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ScheduledEndDateTime != DateTime.MinValue)
            {
                lblScheduledEndDateTime.Text = scheduledMaintenance.ScheduledEndDateTime.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ActualStartDateTime != DateTime.MinValue)
            {
                lblActualStartDateTime.Text = scheduledMaintenance.ActualStartDateTime.ToString(dateTimeStringFormat);
            }
            if (scheduledMaintenance.ActualEndDateTime != DateTime.MinValue)
            {
                lblActualEndDateTime.Text = scheduledMaintenance.ActualEndDateTime.ToString(dateTimeStringFormat);
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
            elapsedTime = DateTime.Now - scheduledMaintenance.ActualStartDateTime;
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

        private void ConditionallyEnableDeleteButton()
        {
            if (scheduledMaintenance != null)
            {
                btnDeleteScheduledMaintenance.Enabled = true;
            }
        }

        private void BtnEditTasks_Click(object sender, EventArgs e)
        {
            EditTasksForm editTasksForm = new EditTasksForm(this);
            editTasksForm.ShowDialog();
        }

        private void BtnStartScheduledMaintenance_Click(object sender, EventArgs e)
        {
            scheduledMaintenance.ActualStartDateTime = DateTime.Now;
            lblActualStartDateTime.Text = scheduledMaintenance.ActualStartDateTime.ToString(dateTimeStringFormat);
            InitializeElapsedTimeTimer();
            btnStartScheduledMaintenance.Enabled = false;
            btnEndScheduledMaintenance.Enabled = true;
            SaveScheduledMaintenancesToFile();
        }

        private void BtnEndScheduledMaintenance_Click(object sender, EventArgs e)
        {
            scheduledMaintenance.ActualEndDateTime = DateTime.Now;
            lblActualEndDateTime.Text = scheduledMaintenance.ActualEndDateTime.ToString(dateTimeStringFormat);
            elapsedTimeTimer.Stop();
            btnStartScheduledMaintenance.Enabled = true;
            btnEndScheduledMaintenance.Enabled = false;
            SaveScheduledMaintenancesToFile();
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
                btnDeleteScheduledMaintenance.Enabled = false;
            }
        }
    }
}
