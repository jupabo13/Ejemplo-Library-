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
    public class MagazineRepository : Repository<Magazine>, IMagazineRepository
    {
        public MagazineRepository(LibraryDbContext libraryDbContext)
            :base(libraryDbContext)
        {

        }
        public void CreateMagazine(Magazine magazine)
        {
            Add(magazine);
        }

        public void DeleteMagazine(Magazine magazine)
        {
            Delete(magazine);
        }

        public async Task<IEnumerable<Magazine>> GetAllMagazineAsync(Expression<Func<Magazine, bool>> filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>> orderBy = null, string includeProperties = null, bool trackChanges = true)
        {
            return await GetAllAsync(filter,orderBy,includeProperties,trackChanges);
        }

        public async Task<Magazine> GetMagazineByIdAsync(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Magazine> GetMagazineDetailsAsync(Expression<Func<Magazine, bool>> filter = null, string includeProperties = null, bool trackChanges = true)
        {
            return await GetFirstOrDefaultAsync(filter: filter, includeProperties: includeProperties, trackChanges: trackChanges);
        }

        public void UpdateMagazine(Magazine magazine)
        {
            Update(magazine);
        }
    }
}
