using DoctorWhoDomain.Repos;
using DoctorWhoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    internal class EpisodeRepo : IEpisodeRepo<Episode>
    {
        private readonly DoctorWhoDBContext _context;

        public EpisodeRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(Episode episode)
        {
            var episodes = _context.Episodes;
            episodes.Add(episode);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int episodeId)
        {
            var episode = _context.Episodes.Where(e => e.EpisodeId.Equals(episodeId)).FirstOrDefault();
            var episodes = _context.Episodes;
            if (episode != null)
                episodes.Remove(episode);
            await SaveChangesAsync();
        }

        public async Task<IList<Episode>> GetAllAsync()
        {
            var episodes = _context.Episodes.ToList();
            await SaveChangesAsync();
            return episodes;

        }

        public async Task<Episode> GetByIdAsync(int episodeId)
        {
            var episode = _context.Episodes.
                Where(e => e.EpisodeId.Equals(episodeId))
                .FirstOrDefault();

            await SaveChangesAsync();
            return episode;
        }

        public async Task UpdateAsync(int episodeId, Episode? episode = null)
        {
            var oldVal = _context.Episodes.Where(
              e => e.DoctorId.Equals(episodeId)).FirstOrDefault();
            if (oldVal != null)
                oldVal = episode;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public async void AddCompanionToEpisodeAsync(Episode episode,Companion companion)
        {
            var myEpisode = _context.Episodes.Where(e => e.Equals(episode)).FirstOrDefault();
            if (myEpisode != null)
                episode.Companions.Add(companion); 
            await SaveChangesAsync();
        }

        public async void AddEnemyToEpisodeAsync(Episode episode, Enemy enemy)
        {
            var myEpisode = _context.Episodes.Where(e => e.Equals(episode)).FirstOrDefault();
            if (myEpisode != null)
                episode.Enemies.Add(enemy);
            await SaveChangesAsync();
        }

    }
}
