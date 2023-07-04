using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Domain.Concrete.Base;

namespace xProject.Domain.Concrete
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public ICollection<Order>? Orders { get; set; } // ManyToMany
    }
}
