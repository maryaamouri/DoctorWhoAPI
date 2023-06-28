using DoctorWhoDomain.Repos;
using DoctorWhoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    public class AuthorRepo : IRepo<Author>
    {
        private readonly DoctorWhoDBContext _context;

        public AuthorRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(Author author)
        {
            var authors = _context.Authors;
            authors.Add(author);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int authorId)
        {
            var author = _context.Authors.Where(e => e.AuthorId.Equals(authorId)).FirstOrDefault();
            var authors = _context.Authors;
            if (author != null)
                authors.Remove(author);
            await SaveChangesAsync();
        }

        public async Task<IList<Author>> GetAllAsync()
        {
            var authors = _context.Authors.ToList();
            await SaveChangesAsync();
            return authors;

        }

        public async Task<Author> GetByIdAsync(int authorId)
        {
            var author = _context.Authors.
                Where(e => e.AuthorId.Equals(authorId))
                .FirstOrDefault();

            await SaveChangesAsync();
            return author;
        }

        public async Task UpdateAsync(int authorId, Author? author = null)
        {
            var oldVal = _context.Authors.Where(
              e => e.AuthorId.Equals(authorId)).FirstOrDefault();
            if (oldVal != null)
                author = oldVal;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
