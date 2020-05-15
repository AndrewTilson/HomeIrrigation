using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeIrrigationAPI.Models
{
    public class Sensor
    {
        public string SensorMac { get; set; }

        public string SiteID { get; set; }

        public int LocationID { get; set; }

        public int PlantType { get; set; }

        public string LocationMap { get; set; }
    }
}
