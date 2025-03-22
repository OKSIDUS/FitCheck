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

        public async Task<bool> CreateAsync(BodyMeasurements bodyMeasurements)
        {
            try
            {
                _logger.LogInformation("Creating body measurement");
                if(bodyMeasurements is null)
                {
                    _logger.LogWarning("Body measurement is null");
                    return false;
                }

                await _dbContext.BodyMeasurements.AddAsync(bodyMeasurements);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("Body measurement added successfully");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Adding new body measurement with error: {ex.Message}, Inner exception: {ex.InnerException}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var bodyMeasurement = await _dbContext.BodyMeasurements.FindAsync(id);
                if (bodyMeasurement is not null)
                {
                    _logger.LogInformation($"Deleting body measurement by ID: {id}");
                    _dbContext.BodyMeasurements.Remove(bodyMeasurement);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Delete successfuly");
                    return true;
                }
                _logger.LogWarning($"Body measurement not found by ID: {id}");
                
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Deleting body measurements by ID: {id}, with error: {ex.Message}, Inner exception: {ex.InnerException}");
                return false;
            }
        }

        public async Task<BodyMeasurements?> GetByIdAsync(int id)
        {
            try
            {
                if (id > 0)
                {
                    _logger.LogInformation($"Getting body measurements by ID {id}");
                    var bodyMeasurement = await _dbContext.BodyMeasurements.FindAsync(id);
                    return bodyMeasurement;

                }
                _logger.LogWarning($"ID is less or equal 0, ID: {id}");

                return null;
            }
            catch(Exception ex)
            {
                _logger.LogError($"Getting body measurements by ID: {id}, with error: {ex.Message}, Inner exception: {ex.InnerException}");
                return null;
            }
            
        }

        public async Task<IEnumerable<BodyMeasurements>?> GetByUserIdAsync(int userId)
        {
            try
            {
                
                if (userId > 0)
                {
                    _logger.LogInformation($"Getting list of body measurements by User ID {userId}");
                    var bodyMeasurements = await _dbContext.BodyMeasurements.Where(b => b.UserId == userId).ToListAsync();
                    return bodyMeasurements;
                }
                _logger.LogWarning($"User ID is less or equal 0, User ID: {userId}");

                return null;
            }
            catch(Exception ex)
            {
                _logger.LogError($"Getting list of body measurements by user ID: {userId}, with error: {ex.Message}, Inner exception: {ex.InnerException}");
                return null;
            }
            
        }

        public async Task<bool> UpdateAsync(BodyMeasurements bodyMeasurements)
        {
            try
            {
                _logger.LogInformation("Updating body measurements");
                if (bodyMeasurements is not null)
                {
                    _dbContext.BodyMeasurements.Update(bodyMeasurements);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Body measurement updated successfully");
                    return true;
                }
                _logger.LogWarning("Body measurement is null");
                return false;
            }
            catch(Exception ex)
            {
                _logger.LogError($"Updating body measurement with error: {ex.Message}, Inner exception: {ex.InnerException}");
                return false;
            }
        }
    }
}
