using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLibrary.Enums;

namespace DataAccessLibrary.Models
{
    public class ScheduledMaintenanceTask
    {
        public string Description { get; set; }
        public string OwnershipGroup { get; set; }
        public DateTime? ScheduledStartDateTime { get; set; } = null;
        public DateTime? ScheduledEndDateTime { get; set; } = null;
        public DateTime? ActualStartDateTime { get; set; } = null;
        public DateTime? ActualEndDateTime { get; set; } = null;
        public ScheduledMaintenanceTaskStatus Status { get; set; } = ScheduledMaintenanceTaskStatus.Scheduled;
        public string Notes { get; set; }
    }
}
