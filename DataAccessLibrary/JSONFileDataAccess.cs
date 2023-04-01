using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class JSONFileDataAccess
    {
        public void WriteAllScheduledMaintenances(List<ScheduledMaintenance> maintenances, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(maintenances);
            File.WriteAllText(filePath, jsonString);
        }

        public List<ScheduledMaintenance> ReadAllScheduledMaintenances(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            List<ScheduledMaintenance> output = JsonSerializer.Deserialize<List<ScheduledMaintenance>>(jsonString);
            return output;
        }
    }
}
