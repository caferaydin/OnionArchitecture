﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Application.Abstract.Repositoriy.GenericRepository;
using xProject.Domain.Concrete;

namespace xProject.Application.Abstract.Repositoriy.WriteRepository
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
