using DoctorWhoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    public class EpisodeRepo : IEpisodeRepo
    {
        private readonly DoctorWhoDBContext _context;

        public EpisodeRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task<Episode> CreateAsync(Episode episode)
        {
            var newEpisode = new Episode
            {
                Number = episode.Number,
                Type = episode.Type,
                Title = episode.Title,
                EpisodeDate = episode.EpisodeDate,
                AuthorId = episode.AuthorId,
                DoctorId = episode.DoctorId,
                Notes = episode.Notes
            };
            newEpisode.Author = await _context.Authors.FindAsync(newEpisode.AuthorId);
            newEpisode.Doctor = await _context.Doctors.FindAsync(newEpisode.DoctorId);
                           
            _context.Episodes.Add(newEpisode);
            await _context.SaveChangesAsync();

            return newEpisode;
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

        public async Task<Episode> AddCompanionToEpisodeAsync(int episodeId, Companion companion)
        {
            var myEpisode = await _context.Episodes.FindAsync(episodeId);
            if (myEpisode != null)
                myEpisode.Companions.Add(companion);
            await SaveChangesAsync();
            return myEpisode;
        }

        public async Task<Episode> AddEnemyToEpisodeAsync(int episodeId, Enemy enemy)
        {
            var myEpisode = await  _context.Episodes.FindAsync(episodeId);
            if (myEpisode != null)
                myEpisode.Enemies.Add(enemy);
            await SaveChangesAsync();
            return myEpisode;
        }

    }
}
