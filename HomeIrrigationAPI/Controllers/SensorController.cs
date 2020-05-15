using System.Threading.Tasks;
using HomeIrrigationAPI.BL;
using HomeIrrigationAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeIrrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        public SensorLogger _sensorlogger { get; }

        public SensorController(SensorLogger SensorLogger)
        {
            _sensorlogger = SensorLogger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _sensorlogger.GetAll();
            return new OkObjectResult(result);
        }

        // POST: api/Sensor
        [HttpPost]
        public IActionResult Post(SensorReading sensorReading)
        {
            sensorReading.SensorMac = sensorReading.SensorMac.Replace(":", string.Empty);
            _sensorlogger.LogSensorReading(sensorReading);
            return Ok();
        }
    }
}
