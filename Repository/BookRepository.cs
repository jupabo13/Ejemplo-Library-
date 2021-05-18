using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {      
        public BookRepository(LibraryDbContext libraryDbContext)
            :base(libraryDbContext)
        {
            
        }
        public void CreateBook(Book book)
        {
            Add(book);
        }

        public void DeleteBook(Book book)
        {
            Delete(book);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, string includeProperties = null, bool trackChanges = true)
        {
            return await GetAllAsync(filter,orderBy,includeProperties,trackChanges);            
        }

        
        public async Task<Book> GetBookByIdAsync(int id)
        {
            //return await GetByIdAsync(id);


            var bookWithAuthors = await (_libraryDbContext.Book.Where(b=>b.PublicationId == id)
             .Include(ab => ab.AuthorsBook).ThenInclude(a => a.Author).ThenInclude(n => n.Nationality)
             .Include(f => f.Format)
             .Include(p => p.Publisher))
             .FirstOrDefaultAsync();

            return bookWithAuthors;
        }

        public async Task<Book> GetBookWithDetailsAsync(Expression<Func<Book, bool>> filter = null, string includeProperties = null, bool trackChanges = true)
        {
            return await GetFirstOrDefaultAsync(filter: filter, includeProperties: includeProperties, trackChanges: trackChanges);

        }

        public void UpdateBook(Book book)
        {
            Update(book);
        }

        /* nuevo */
            /* Métodos sobrecargados */
                public void CreateBookForAuthor(Author author, Book book)
                {

                    book.AuthorsBook = new List<AuthorBook>
                    {
                        new AuthorBook
                        {
                            Author = author,
                            Book = book
                        }
                    };
                    CreateBook(book);            
                }

                public void CreateBookForAuthor(List<Author> authors, Book book)
                {

                    book.AuthorsBook = new List<AuthorBook>();
                    
                    foreach (var item in authors)
                    {
                        book.AuthorsBook.Add(
                            new AuthorBook
                            {
                                Author = item,
                                Book = book
                            }
                        );
                    };                    
                    CreateBook(book);
                }
        /* Fin Métodos sobrecargados */



        public async Task<Book> GetBookByAuthorIdAndPublicationId(int authorId, int id, bool tracChanges = false)
        {
            var bookWithAuthors =  await ( _libraryDbContext.Book.Where(b => b.PublicationId == id)
                .Include(ab => ab.AuthorsBook).ThenInclude(a => a.Author).ThenInclude(n=>n.Nationality)
                .Include(f => f.Format)
                .Include(p => p.Publisher))
                .Select(book => new Book()
                {
                    PublicationId = book.PublicationId,
                    ISBN = book.ISBN,
                    Title = book.Title,
                    SubTitle = book.SubTitle,
                    Published = book.Published,
                    PublisherId = book.PublisherId,
                    Publisher = book.Publisher,
                    NumberOfPages = book.NumberOfPages,
                    Description = book.Description,
                    FormatId =book.FormatId,
                    WebSite = book.WebSite,
                    Format = book.Format,
                    AuthorsBook = book.AuthorsBook.Where(x => x.AuthorId == authorId).ToList()
                }).FirstAsync();
            
            return bookWithAuthors;
        }

        
        public async Task<IEnumerable<Book>> GetAllBooksWithAuthorsAsync(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, bool trackChanges = false)
        {
            var booksWithAuthors = await _libraryDbContext.Book
               .Include(f => f.Format)
               .Include(p => p.Publisher)
               .Include(ab => ab.AuthorsBook).ThenInclude(a => a.Author).ThenInclude(n => n.Nationality)               
               .ToListAsync();

            return booksWithAuthors;
        }      

        /* Fin Nuevo */
    }
}
