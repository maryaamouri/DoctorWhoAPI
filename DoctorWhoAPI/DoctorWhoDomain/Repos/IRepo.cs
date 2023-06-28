using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Repos
{
    public interface IRepo<T> where T : class
    {
        public Task CreateAsync(T Entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id,T Entity);
        public Task <T> GetByIdAsync(int id);
        public Task<IList<T>> GetAllAsync();
    }
}
