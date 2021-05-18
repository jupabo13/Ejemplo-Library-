using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepository<T>
    {
        /* Get All T */
       Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null, bool trackChanges = true);

        /* Get T By ID  */
        Task<T> GetByIdAsync(int id);

        /* Get T First Or Default  */
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool trackChanges = true);

        /* Add T Entity */
        void Add(T entity);

        /* Update T */
        void Update(T entity);

        /* Delete T By Id*/
        void Delete(int id);

        /* Delete by T */
        void Delete(T entity);
    }
}
