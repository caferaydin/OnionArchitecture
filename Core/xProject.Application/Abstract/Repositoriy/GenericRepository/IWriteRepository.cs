using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Domain.Concrete.Base;

namespace xProject.Application.Abstract.Repositoriy.GenericRepository
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> datas);
        bool UpdateAsync(T entity);
        bool Delete(T entity);
        bool DeleteRange(List<T> datas);
        Task<bool> DeleteAsync(string id);
        Task<int> SaveAsync();


    }
}
