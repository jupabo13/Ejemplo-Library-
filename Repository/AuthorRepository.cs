using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext libraryDbContext)
            :base(libraryDbContext)
        {

        }

        /* New Methods */
        public async Task<IEnumerable<Author>> GetAllAuthorsWithBooksAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, bool trackChanges = true)
        {
            return await _libraryDbContext.Author
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Publisher)
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Format)
                .Include(n => n.Nationality)
                .ToListAsync();
        }

        public async Task<Author> GetAuthorByIdWithBooksAsync(int id)
        {
            return await _libraryDbContext.Author.Where(a => a.AuthorId == id)
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Publisher)
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Format)
                .Include(n => n.Nationality)
                .FirstOrDefaultAsync();
        }

        public async Task<Author>  GetAuthorByIdWithBookIdAsync(int publicationId, int authorId)
        {
            var authorWithBook = await  (_libraryDbContext.Author.Where(a => a.AuthorId == authorId)
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Publisher)
                .Include(ab => ab.AuthorBooks).ThenInclude(a => a.Book).ThenInclude(x => x.Format)
                .Include(n => n.Nationality))
                .Select(author => new Author()
                {
                    AuthorId = author.AuthorId,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    NationalityId = author.NationalityId,
                    Nationality = author.Nationality,
                    AuthorBooks = author.AuthorBooks.Where(x => x.PublicationId == publicationId).ToList()
                }).FirstOrDefaultAsync();

            return authorWithBook;
        }

        public async Task<AuthorBook> ValidateAuthorWithPublication(int authorId, int publicationId)
        {
            var result = await _libraryDbContext.AuthorBook.Where(x => x.AuthorId == authorId && x.PublicationId == publicationId).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Author>> GetAuthorsByIdsAsync(List<int> authorsIds)
        {
            List<Author> authors = new List<Author>();

            foreach (var item in authorsIds)
            {
               authors.Add(await _libraryDbContext.Author.Where(a => a.AuthorId == item).FirstOrDefaultAsync());
            }

            return authors;
        }

        /* End New Methods */

        public void CreateAuthor(Author author)
        {
            Add(author);
        }

        public void DeleteAuthor(Author author)
        {
            Delete(author);
        }

        public void UpdateAuthor(Author author)
        {
            Update(author);
        }

        /* Candidates to Delete */
            public async Task<IEnumerable<Author>> GetAllAuthorsWithOutBooksAsync(Expression<Func<Author, bool>> filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>> orderBy = null, string includeProperties = null, bool trackChanges = true)
            {
                return await GetAllAsync(filter, orderBy, includeProperties,trackChanges); 
            }       

            public async Task<Author> GetAuthorWithOutBooksAsync(Expression<Func<Author, bool>> filter = null, string includeProperties = null, bool trackChanges = true)
            {
                return await GetFirstOrDefaultAsync(filter: filter, includeProperties: includeProperties, trackChanges:trackChanges);
            }       
        /* End Candidates to Delete */
    }
}
