using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using xProject.Application.Abstract.Repositoriy.GenericRepository;
using xProject.Domain.Concrete.Base;
using xProject.Persistence.Contexts;

namespace xProject.Persistence.Concrete.Repository.GenericRepository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly private MsSqlxProjectContext _context;

        public ReadRepository(MsSqlxProjectContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query = Table.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
            //=> await Table.FindAsync(Guid.Parse(id));
            //=> await Table.SingleOrDefaultAsync(data => data.Id == Guid.Parse(id));
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(filter);
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(filter);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true)
        {
            var query = Table.Where(filter);
            if(!tracking)
                query = Table.AsNoTracking();
            return query;
        }
    }
}
