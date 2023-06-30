using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xProject.Domain.Concrete
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }

        public ICollection<Order>? Orders { get; set; } // ManyToMany
    }
}
