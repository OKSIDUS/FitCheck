using AutoMapper;
using FitCheck.BAL.Dtos;
using FitCheck.BAL.Interfaces;
using FitCheck.DAL.DataContext.Entity;
using FitCheck.DAL.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitCheck.BAL.Services
{
    public class BodyMeasrumentService : IBodyMeasurementService
    {
        private readonly IBodyMeasurementRepository _bodyMeasurementRepository;
        private readonly ILogger<BodyMeasrumentService> _logger;
        private readonly IMapper _mapper;

        public BodyMeasrumentService(IBodyMeasurementRepository bodyMeasurementRepository, ILogger<BodyMeasrumentService> logger, IMapper mapper)
        {
            _bodyMeasurementRepository = bodyMeasurementRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<bool> CreateBodyMeasurementAsync(CreateBodyMeasurementDto bodyMeasurementDto)
        {
            try
            {
                if (bodyMeasurementDto is not null)
                {
                    var result = await _bodyMeasurementRepository.CreateAsync(_mapper.Map<BodyMeasurements>(bodyMeasurementDto));
                    return result;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
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
