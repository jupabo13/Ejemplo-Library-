using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBookRepository 
        //: IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, string includeProperties = null, bool trackChanges = true);
        Task<Book> GetBookByIdAsync(int id);

        /* Candidatos a Borrar */
            Task<Book> GetBookWithDetailsAsync(Expression<Func<Book, bool>> filter = null, string includeProperties = null, bool trackChanges = true);      

       /* Fin Candidato a Borrar */

        void CreateBookForAuthor(Author author, Book book);
        void CreateBookForAuthor(List<Author> authors, Book book);


        /* New Methods */
            Task<Book> GetBookByAuthorIdAndPublicationId(int authorId, int id, bool tracChanges = false);
            Task<IEnumerable<Book>> GetAllBooksWithAuthorsAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, bool trackChanges = false);
        /* New Methods */


        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
