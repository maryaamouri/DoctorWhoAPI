using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface IEpisodeRepo
    {
        Task<Episode> AddCompanionToEpisodeAsync(int episodeId, Companion companion);
        Task<Episode> AddEnemyToEpisodeAsync(int episodeId, Enemy enemy);
        Task<Episode> CreateAsync(Episode episode);
        Task DeleteAsync(int episodeId);
        Task<IList<Episode>> GetAllAsync();
        Task<Episode> GetByIdAsync(int episodeId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int episodeId, Episode? episode = null);
    }
}