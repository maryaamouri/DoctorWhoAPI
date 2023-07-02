using DoctorWhoDomain.Entities;

namespace DoctorWhoData.Repos
{
    public interface IAuthorRepo
    {
        Task CreateAsync(Author author);
        Task DeleteAsync(int authorId);
        Task<IList<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(int authorId);
        Task<bool> SaveChangesAsync();
        Task UpdateAsync(int authorId, Author? author = null);
    }
}