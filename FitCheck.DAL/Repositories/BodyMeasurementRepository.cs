using FitCheck.DAL.DataContext;
using FitCheck.DAL.DataContext.Entity;
using FitCheck.DAL.Interfaces;
using Microsoft.Extensions.Logging;

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

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BodyMeasurements> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BodyMeasurements>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(BodyMeasurements bodyMeasurements)
        {
            throw new NotImplementedException();
        }
    }
}
