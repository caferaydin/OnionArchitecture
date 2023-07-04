using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Application.Abstract.Repositoriy.ReadRepository;
using xProject.Domain.Concrete;
using xProject.Persistence.Concrete.Repository.GenericRepository;
using xProject.Persistence.Contexts;

namespace xProject.Persistence.Concrete.Repository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(MsSqlxProjectContext context) : base(context)
        {
        }
    }
}
