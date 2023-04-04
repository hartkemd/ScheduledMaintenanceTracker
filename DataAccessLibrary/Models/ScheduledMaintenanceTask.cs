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
        public DateTime ScheduledStartDateTime { get; set; }
        public DateTime ScheduledEndDateTime { get; set; }
        public DateTime ActualStartDateTime { get; set; }
        public DateTime ActualEndDateTime { get; set; }
        public ScheduledMaintenanceTaskStatus Status { get; set; } = ScheduledMaintenanceTaskStatus.Scheduled;
    }
}
