using Entities.Concrete;
using System;

namespace Entity.Concrete
{
    public class Invoice : BaseEntity
    {
        public float RentMoney { get; set; }
        public DateTime? Date { get; set; }
        public int RentId { get; set; }



        // NAV properties
        public Rent Rent { get; set; }
    }
}
