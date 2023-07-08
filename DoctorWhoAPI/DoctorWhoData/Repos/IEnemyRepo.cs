using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface IEnemyRepo
    {
        Task CreateAsync(Enemy enemy);
        Task DeleteAsync(int enemyId);
        Task<IList<Enemy>> GetAllAsync();
        Task<Enemy> GetByIdAsync(int enemyId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int enemyId, Enemy? enemy = null);
    }
}