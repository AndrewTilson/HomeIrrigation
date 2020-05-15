using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeIrrigationAPI.Models
{
    public class SensorCalibration
    {
        public string SensorMac { get; set; }

        public DateTime CalibartionTS { get; set; }

        public int SensorLow { get; set; }

        public int SensorHigh { get; set; }
    }
}
