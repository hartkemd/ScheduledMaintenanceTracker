using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ScheduledMaintenanceTask
    {
        public string Name { get; set; }
        public DateTime ExpectedStartDateTime { get; set; }
        public DateTime ExpectedEndDateTime { get; set; }
        public DateTime ActualStartDateTime { get; set; }
        public DateTime ActualEndDateTime { get; set; }
    }
}
