using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ScheduledMaintenance
    {
        public List<ScheduledMaintenanceTask> Tasks { get; set; } = new List<ScheduledMaintenanceTask>();
        public DateTime? ScheduledStartDateTime { get; set; } = null;
        public DateTime? ScheduledEndDateTime { get; set; } = null;
        public DateTime? ActualStartDateTime { get; set; } = null;
        public DateTime? ActualEndDateTime { get; set; } = null;
    }
}
