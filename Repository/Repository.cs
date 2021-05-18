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
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected LibraryDbContext _libraryDbContext;

        public Repository(LibraryDbContext libraryDbContext)
        {
            this._libraryDbContext = libraryDbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null, bool trackChanges = false)
        {
            IQueryable<T> query = _libraryDbContext.Set<T>();
            
            if (!trackChanges)
            {
                _libraryDbContext.Set<T>().AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties separadas por comas
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if (orderBy != null)
            {
               query = orderBy(query);
            }
           
            return await query.ToListAsync();
        }      
        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool trackChanges = false)
        {
            IQueryable<T> query = _libraryDbContext.Set<T>();
            if (!trackChanges)
            {
                _libraryDbContext.Set<T>().AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //Include properties separadas por comas
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _libraryDbContext.Set<T>().FindAsync(id);            
        }

        public void Add(T entity)
        {
            _libraryDbContext.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            T entityToRemove = _libraryDbContext.Set<T>().Find(id);
            Delete(entityToRemove);
        }

        public void Delete(T entity)
        {
            _libraryDbContext.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _libraryDbContext.Set<T>().Update(entity);
        }
    }
}
