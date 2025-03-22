using FitCheck.DAL.DataContext.Entity;
using Microsoft.EntityFrameworkCore;

namespace FitCheck.DAL.DataContext
{
    public class FitCheckDbContext : DbContext
    {
        public FitCheckDbContext(DbContextOptions<FitCheckDbContext> options) : base(options) { }

        public DbSet<BodyMeasurements> BodyMeasurements { get; set; }
    }
}
