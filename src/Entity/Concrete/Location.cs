using Entities.Concrete;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Location : BaseEntity
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CarId { get; set; }


        // NAV properties
        public List<Car> Cars { get; set; }
    }
}
