using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    class Status
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
