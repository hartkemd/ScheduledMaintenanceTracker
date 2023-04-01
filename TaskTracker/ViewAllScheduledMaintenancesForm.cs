using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskTracker
{
    public partial class ViewAllScheduledMaintenancesForm : Form
    {
        private MainForm _mainForm;

        public ViewAllScheduledMaintenancesForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            SetListBoxDataSource();
        }

        private void SetListBoxDataSource()
        {
            lbxAllScheduledMaintenances.DataSource = null;
            lbxAllScheduledMaintenances.DataSource = _mainForm.scheduledMaintenances;
            lbxAllScheduledMaintenances.DisplayMember = "ScheduledStartDateTime";
        }

        private void BtnDeleteScheduledMaintenance_Click(object sender, EventArgs e)
        {
            if (_mainForm.scheduledMaintenances.Count > 0)
            {
                var confirmResult = MessageBox.Show("Delete this scheduled maintenance?",
                                     "Proceed?",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Exclamation);
                if (confirmResult == DialogResult.Yes)
                {
                    _mainForm.scheduledMaintenances.RemoveAt(lbxAllScheduledMaintenances.SelectedIndex);
                    _mainForm.SaveScheduledMaintenancesToFile();
                    SetListBoxDataSource();
                }
            }
        }
    }
}
