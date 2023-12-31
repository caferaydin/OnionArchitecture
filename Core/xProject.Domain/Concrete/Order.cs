﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Domain.Concrete.Base;

namespace xProject.Domain.Concrete
{
    public class Order : BaseEntity
    {
        public string? Address { get; set; }
        public ICollection<Product>? Products { get; set; } // ManyToMany
        public Customer Customer { get; set; }
    }
}
