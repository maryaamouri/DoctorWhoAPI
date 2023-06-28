using DoctorWhoDomain.Repos;
using DoctorWhoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    public class CompanionRepo : IRepo<Companion>
    {
        private readonly DoctorWhoDBContext _context;

        public CompanionRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(Companion companion)
        {
            var companions = _context.Companions;
            companions.Add(companion);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int companionId)
        {
            var companion = _context.Companions.Where(e => e.CompanionId.Equals(companionId)).FirstOrDefault();
            var companions = _context.Companions;
            if (companion != null)
                companions.Remove(companion);
            await SaveChangesAsync();
        }

        public async Task<IList<Companion>> GetAllAsync()
        {
            var companions = _context.Companions.ToList();
            await SaveChangesAsync();
            return companions;

        }

        public async Task<Companion> GetByIdAsync(int companionId)
        {
            var companion = _context.Companions.
                Where(e => e.CompanionId.Equals(companionId))
                .FirstOrDefault();

            await SaveChangesAsync();
            return companion;
        }

        public async Task UpdateAsync(int companionId, Companion? companion = null)
        {
            var oldVal = _context.Companions.Where(
              e => e.CompanionId.Equals(companionId)).FirstOrDefault();
            if (oldVal != null)
                companion = oldVal;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
