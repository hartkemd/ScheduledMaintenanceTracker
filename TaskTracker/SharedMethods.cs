using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public static class SharedMethods
    {
        public static void FormatDataGridView(DataGridView dgv)
        {
            dgv.Columns[2].DefaultCellStyle.Format = "h:mm tt";
            dgv.Columns[3].DefaultCellStyle.Format = "h:mm tt";
            dgv.Columns[4].DefaultCellStyle.Format = "h:mm tt";
            dgv.Columns[5].DefaultCellStyle.Format = "h:mm tt";
            dgv.Columns[1].HeaderText = "Ownership Group";
            dgv.Columns[2].HeaderText = "Scheduled Start Time";
            dgv.Columns[3].HeaderText = "Scheduled End Time";
            dgv.Columns[4].HeaderText = "Actual Start Time";
            dgv.Columns[5].HeaderText = "Actual End Time";
        }
    }
}
