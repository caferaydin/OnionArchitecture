using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xProject.Domain.Concrete
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string? Address { get; set; }

        public ICollection<Product>? Products { get; set; } // ManyToMany
        public Customer Customer { get; set; }
    }
}
