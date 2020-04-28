using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeIrrigationAPI.BL;
using HomeIrrigationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace HomeIrrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        public MySqlConnection Connection { get; }

        public SensorController()
        {
            Connection = new MySqlConnection("Server=localhost;User Id=*;Password=*;Database=IrrigationDB");
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    await Connection.OpenAsync();
        //    var query = new SensorReadingsModel(Connection);
        //    var result = await query.GetAll();
        //    return new OkObjectResult(result);
        //}

        // POST: api/Sensor
        [HttpPost]
        public IActionResult Post(SensorReadingsModel sensorReading)
        {
            Connection.Open();
            var Logger = new DataLogger(Connection);
            Logger.LogReading(sensorReading);
            return Ok();
        }
    }
}
