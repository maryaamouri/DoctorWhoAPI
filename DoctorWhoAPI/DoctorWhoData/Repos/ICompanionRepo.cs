using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface ICompanionRepo
    {
        Task CreateAsync(Companion companion);
        Task DeleteAsync(int companionId);
        Task<IList<Companion>> GetAllAsync();
        Task<Companion> GetByIdAsync(int companionId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int companionId, Companion? companion = null);
    }
}