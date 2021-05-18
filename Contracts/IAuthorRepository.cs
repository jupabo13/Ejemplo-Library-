using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthorRepository 
        //: IRepository<Author>
    {       
        /* New Methods */
                Task<IEnumerable<Author>> GetAllAuthorsWithBooksAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, bool trackChanges = true);
                Task<Author> GetAuthorByIdWithBooksAsync(int id);
                Task<Author> GetAuthorByIdWithBookIdAsync(int publicationId, int authorId);
                Task<AuthorBook> ValidateAuthorWithPublication(int authorId, int publicationId);
                Task<List<Author>> GetAuthorsByIdsAsync(List<int> authorsIds);

        /* New Methods */

        /* Candidates to Delete */
            Task<IEnumerable<Author>> GetAllAuthorsWithOutBooksAsync(Expression<Func<Author, bool>> filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>> orderBy = null, string includeProperties = null, bool trackChanges = true);            
            Task<Author> GetAuthorWithOutBooksAsync(Expression<Func<Author, bool>> filter = null, string includeProperties = null, bool trackChanges = true);

        /* End Candidates to Delete */

            void CreateAuthor(Author author);
            void UpdateAuthor(Author author);
            void DeleteAuthor(Author author);
        
    }
}
