using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskTracker
{
    public partial class EditScheduledMaintenanceForm : Form
    {
        private MainForm _mainForm;
        string dateTimeStringFormat = "M/dd/yyyy h:mm tt";

        public EditScheduledMaintenanceForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            dtpExpectedStartTime.CustomFormat = "hh:mm tt";
            dtpExpectedStartTime.Format = DateTimePickerFormat.Custom;
            dtpExpectedStartTime.ShowUpDown = true;
            dtpExpectedStartTime.Value = DateTime.Now.Date;

            dtpExpectedEndTime.CustomFormat = "hh:mm tt";
            dtpExpectedEndTime.Format = DateTimePickerFormat.Custom;
            dtpExpectedEndTime.ShowUpDown = true;
            dtpExpectedEndTime.Value = DateTime.Now.Date.AddHours(4);

            FormClosing += EditScheduledMaintenanceForm_FormClosing;
        }

        private void EditScheduledMaintenanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.scheduledMaintenance.ScheduledStartDateTime = dtpExpectedStartDate.Value.Date +
                dtpExpectedStartTime.Value.TimeOfDay;
            _mainForm.scheduledMaintenance.ScheduledEndDateTime = dtpExpectedEndDate.Value.Date +
                dtpExpectedEndTime.Value.TimeOfDay;
            _mainForm.lblScheduledStartDateTime.Text =
                _mainForm.scheduledMaintenance.ScheduledStartDateTime.ToString(dateTimeStringFormat);
            _mainForm.lblScheduledEndDateTime.Text =
                _mainForm.scheduledMaintenance.ScheduledEndDateTime.ToString(dateTimeStringFormat);

            _mainForm.SaveScheduledMaintenancesToFile();
        }

        private void DtpExpectedStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpExpectedEndDate.Value = dtpExpectedStartDate.Value;
        }
    }
}
