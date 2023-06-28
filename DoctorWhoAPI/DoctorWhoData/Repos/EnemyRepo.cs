using DoctorWhoDomain;
using DoctorWhoDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    public class EnemyRepo : IRepo<Enemy>
    {
        private readonly DoctorWhoDBContext _context;

        public EnemyRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(Enemy enemy)
        {
            var enemies = _context.Enemies;
            enemies.Add(enemy);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int enemyId)
        {
            var enemy = _context.Enemies.Where(e => e.EnemyId.Equals(enemyId)).FirstOrDefault();
            var enemies = _context.Enemies;
            if (enemy != null)
                enemies.Remove(enemy);
            await SaveChangesAsync();
        }

        public async Task<IList<Enemy>> GetAllAsync()
        {
            var enemies = _context.Enemies.ToList();
            await SaveChangesAsync();
            return enemies;

        }

        public async Task<Enemy> GetByIdAsync(int enemyId)
        {
            var enemy = _context.Enemies.
                Where(e => e.EnemyId.Equals(enemyId))
                .FirstOrDefault();

            await SaveChangesAsync();
            return enemy;
        }

        public async Task UpdateAsync(int enemyId, Enemy? enemy = null)
        {
            var oldVal = _context.Enemies.Where(
              e => e.EnemyId.Equals(enemyId)).FirstOrDefault();
            if (oldVal != null)
                enemy = oldVal;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
