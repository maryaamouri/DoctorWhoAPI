using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface IEpisodeRepo
    {
        void AddCompanionToEpisodeAsync(Episode episode, Companion companion);
        void AddEnemyToEpisodeAsync(Episode episode, Enemy enemy);
        Task CreateAsync(Episode episode);
        Task DeleteAsync(int episodeId);
        Task<IList<Episode>> GetAllAsync();
        Task<Episode> GetByIdAsync(int episodeId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int episodeId, Episode? episode = null);
    }
}