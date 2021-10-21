using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Location : BaseEntity
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
