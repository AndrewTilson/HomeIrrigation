using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeIrrigationAPI.Models
{
    public class SensorReadingsModel : IDisposable
    {
        public DateTime RecordedTS { get; set; }

        public int ID { get; set; }

        public int SensorID { get; set; }

        public int Temp { get; set; }

        public int Moisture { get; set; }

        public MySqlConnection Connection { get; }

        public SensorReadingsModel(MySqlConnection connection)
        {
            Connection = connection;
        }

        public async Task<string> GetAll()
        {
            var cmd = Connection.CreateCommand();
            cmd.CommandText = "select count(*) SensorReadings";
            var result = await cmd.ExecuteReaderAsync();

            string results = "";
            while (result.Read())
            {
                results = results + result.GetInt32(0);
            }

            return results;
        }

        public void Dispose() => Connection.Dispose();
    }
}
