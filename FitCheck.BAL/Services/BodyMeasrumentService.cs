using FitCheck.BAL.Dtos;
using FitCheck.BAL.Interfaces;
using FitCheck.DAL.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitCheck.BAL.Services
{
    public class BodyMeasrumentService : IBodyMeasurementService
    {
        private readonly IBodyMeasurementRepository _bodyMeasurementRepository;
        private readonly ILogger<BodyMeasrumentService> _logger;

        public BodyMeasrumentService(IBodyMeasurementRepository bodyMeasurementRepository, ILogger<BodyMeasrumentService> logger)
        {
            _bodyMeasurementRepository = bodyMeasurementRepository;
            _logger = logger;
        }

        public Task<bool> CreateBodyMeasurementAsync(CreateBodyMeasurementDto bodyMeasurementDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBodyMeasurementAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BodyMeasurementDto> GetBodyMeasurementByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BodyMeasurementDto>> GetBodyMeasurementsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBodyMeasurementAsync(BodyMeasurementDto bodyMeasurementDto)
        {
            throw new NotImplementedException();
        }
    }
}
