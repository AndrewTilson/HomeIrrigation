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

        public int LocationID { get; set; }

        public int SensorID { get; set; }

        public int Moisture { get; set; }

        public DateTime RecordedTS { get; set; }
    }
}
