﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeIrrigationAPI.DBContext;
using HomeIrrigationAPI.Models;

namespace HomeIrrigationAPI.BL
{
    public class DataLogger
    {
        private IrrigationContext _context { get; }

        public DataLogger(IrrigationContext Context)
        {
            _context = Context;
        }

        public async Task<List<SensorReading>> GetAll()
        {
            return _context.SensorReadings.ToList();
        }

        public void LogSensorReading(SensorReading Data)
        {
            _context.Add(Data);
            _context.SaveChanges();
            return;
        }
    }
}
