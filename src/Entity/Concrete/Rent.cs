using System;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Rent : BaseEntity
    {
        public DateTime? DeliveryDay { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? RentBeginDate { get; set; }

        // NAV properties
        public Invoice Invoice { get; set; }
        public List<RentCar> RentCars { get; set; }
    }
}
