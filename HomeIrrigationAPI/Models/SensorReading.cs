using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeIrrigationAPI.Models
{
    public class SensorReading
    {
        public int ID { get; set; }

        public DateTime RecordedTS { get; set; }

        public string SensorMac { get; set; }

        public int Reading { get; set; }
    }
}
