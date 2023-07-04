using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Domain.Concrete.Base;

namespace xProject.Domain.Concrete
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}
