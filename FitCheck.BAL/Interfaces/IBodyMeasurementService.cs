using FitCheck.BAL.Dtos;

namespace FitCheck.BAL.Interfaces
{
    public interface IBodyMeasurementService
    {
        Task<List<BodyMeasurementDto>> GetBodyMeasurementsByUserIdAsync(int userId);
        Task<BodyMeasurementDto> GetBodyMeasurementByIdAsync(int id);
        Task<bool> UpdateBodyMeasurementAsync(BodyMeasurementDto bodyMeasurementDto);
        Task<bool> DeleteBodyMeasurementAsync(int id);
        Task<bool> CreateBodyMeasurementAsync(CreateBodyMeasurementDto bodyMeasurementDto);
    }
}
