using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xProject.Domain.Concrete.Base;

namespace xProject.Domain.Concrete
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public string? Password { get; set; }

    }
}
