using System.Collections.Generic;
using Entities.Concrete;

namespace Entity.Concrete
{
    public class Customer : BaseEntity
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }


        // NAV properties
        public List<Rent> Rents { get; set; }
    }
}
