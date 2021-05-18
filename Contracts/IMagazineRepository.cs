using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMagazineRepository 
        //: IRepository<Magazine>
    {
        Task<IEnumerable<Magazine>> GetAllMagazineAsync(Expression<Func<Magazine, bool>> filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>> orderBy = null, string includeProperties = null, bool trackChanges = true);
        Task<Magazine> GetMagazineByIdAsync(int id);
        Task<Magazine> GetMagazineDetailsAsync(Expression<Func<Magazine, bool>> filter = null, string includeProperties = null, bool trackChanges = true);
        void CreateMagazine(Magazine magazine);
        void UpdateMagazine(Magazine magazine);
        void DeleteMagazine(Magazine magazine);
    }
}
