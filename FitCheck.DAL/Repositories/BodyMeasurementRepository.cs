using FitCheck.DAL.DataContext;
using FitCheck.DAL.DataContext.Entity;
using FitCheck.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace FitCheck.DAL.Repositories
{
    public class BodyMeasurementRepository : IBodyMeasurementRepository
    {
        private readonly ILogger<BodyMeasurementRepository> _logger;
        private readonly FitCheckDbContext _dbContext;

        public BodyMeasurementRepository(FitCheckDbContext dbContext, ILogger<BodyMeasurementRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var bodyMeasurement = await _dbContext.BodyMeasurements.FindAsync(id);
                if (bodyMeasurement is not null)
                {
                    _dbContext.BodyMeasurements.Remove(bodyMeasurement);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public async Task<BodyMeasurements?> GetByIdAsync(int id)
        {
            try
            {
                if (id > 0)
                {
                    var bodyMeasurement = await _dbContext.BodyMeasurements.FindAsync(id);
                    return bodyMeasurement;

                }

                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public async Task<IEnumerable<BodyMeasurements>> GetByUserIdAsync(int userId)
        {
            try
            {
                if (userId > 0)
                {
                    var bodyMeasurements = await _dbContext.BodyMeasurements.Where(b => b.UserId == userId).ToListAsync();
                    return bodyMeasurements;
                }

                return new List<BodyMeasurements>();
            }
            catch(Exception ex)
            {
                return new List<BodyMeasurements>();
            }
            
        }

        public async Task<bool> UpdateAsync(BodyMeasurements bodyMeasurements)
        {
            try
            {
                if (bodyMeasurements is not null)
                {
                    _dbContext.BodyMeasurements.Update(bodyMeasurements);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
