using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Location : BaseEntity
    {
        public int LocationId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
