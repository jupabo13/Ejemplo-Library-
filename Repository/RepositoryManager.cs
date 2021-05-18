using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class RepositoryManager : IRepositoryManager
    {
        Entities.LibraryDbContext _libraryDbContext;
        public RepositoryManager(LibraryDbContext libraryDbContext)
        {
            this._libraryDbContext = libraryDbContext;
        }

        public IBookRepository _bookRepository;

        public IAuthorRepository _authorRepository;

        public IMagazineRepository _magazineRepository;


        public IBookRepository Book
        {
            get
            {
                if (_bookRepository==null)
                {
                    _bookRepository = new BookRepository(_libraryDbContext);
                }
                return _bookRepository;
            }

        }

        public IAuthorRepository Author
        {
            get
            {
                if (_authorRepository == null)
                {
                    _authorRepository = new AuthorRepository(_libraryDbContext);
                }
                return _authorRepository;
            }
        }

        public IMagazineRepository Magazine
        {
            get
            {
                if (_magazineRepository==null)
                {
                    _magazineRepository = new MagazineRepository(_libraryDbContext);
                }
                return _magazineRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _libraryDbContext.SaveChangesAsync();
        }
    }
}
