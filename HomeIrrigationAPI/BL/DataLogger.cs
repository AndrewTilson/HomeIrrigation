using System;
using System.Threading.Tasks;
using HomeIrrigationAPI.Models;
using MySql.Data.MySqlClient;

namespace HomeIrrigationAPI.BL
{
    public class DataLogger : IDisposable
    {
        private MySqlConnection Connection { get; }

        public DataLogger(MySqlConnection connection)
        {
            Connection = connection;
        }

        public async Task<string> GetAll()
        {
            var cmd = Connection.CreateCommand();
            cmd.CommandText = "select count(*) from SensorReadings";
            var result = await cmd.ExecuteReaderAsync();

            string results = "";
            while (result.Read())
            {
                results = results + result.GetInt32(0);
            }

            return results;
        }

        public void LogReading(SensorReadingsModel Data)
        {
            var cmd = Connection.CreateCommand();
            cmd.CommandText = "INSERT INTO `SensorReadings`(`ID`, `SensorID`, `RecordedTS`, `Moisture`) VALUES (" + Data.LocationID + "," + Data.SensorID + "," + DateTime.Now.ToString() + "," + Data.Moisture + ")";
            var result = cmd.ExecuteNonQuery();

        }

        public void Dispose() => Connection.Dispose();
    }
}
