using System.Threading.Tasks;
using HomeIrrigationAPI.BL;
using HomeIrrigationAPI.DBContext;
using HomeIrrigationAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeIrrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        public IrrigationContext context { get; }

        public SensorController(IrrigationContext Context)
        {
            context = Context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = new DataLogger(context);
            var result = await data.GetAll();
            return new OkObjectResult(result);
        }

        // POST: api/Sensor
        [HttpPost]
        public IActionResult Post(SensorReading sensorReading)
        {
            var data = new DataLogger(context);
            data.LogSensorReading(sensorReading);
            return Ok();
        }
    }
}
