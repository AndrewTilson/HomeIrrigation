using HomeIrrigationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIrrigationAPI.DBContext
{
    public class IrrigationContext : DbContext
    {
        public IrrigationContext(DbContextOptions<IrrigationContext> options) : base(options) { }
        public DbSet<SensorReading> SensorReadings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SensorReading>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.LocationID).IsRequired();
                entity.Property(e => e.SensorID).IsRequired();
            });
        }
    }
}
