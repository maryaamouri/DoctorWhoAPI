using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface IDoctorRepo
    {
        Task CreateAsync(Doctor doctor);
        Task DeleteAsync(int doctorId);
        Task<IList<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(int doctorId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int doctorId, Doctor? doctor = null);
    }
}