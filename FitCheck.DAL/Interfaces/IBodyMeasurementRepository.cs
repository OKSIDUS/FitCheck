using FitCheck.DAL.DataContext.Entity;

namespace FitCheck.DAL.Interfaces
{
    public interface IBodyMeasurementRepository
    {
        Task<BodyMeasurements?> GetByIdAsync(int id);
        Task<IEnumerable<BodyMeasurements>> GetByUserIdAsync(int userId);
        Task<bool> UpdateAsync(BodyMeasurements bodyMeasurements);
        Task<bool> DeleteAsync(int id);
    }
}
