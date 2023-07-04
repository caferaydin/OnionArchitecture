using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Application.Abstract.Repositoriy.WriteRepository;
using xProject.Domain.Concrete;
using xProject.Persistence.Concrete.Repository.GenericRepository;
using xProject.Persistence.Contexts;

namespace xProject.Persistence.Concrete.Repository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(MsSqlxProjectContext context) : base(context)
        {
        }
    }
}
