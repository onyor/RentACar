using System.Collections.Generic;
using Entities.Concrete;

namespace Entity.Concrete
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }


        // NAV properties
        public List<Car> Cars { get; set; }
    }
}
