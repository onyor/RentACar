using System;

namespace Entity.Concrete
{
    public class Invoice : BaseEntity
    {
        public float RentMoney { get; set; }
        public DateTime? Date { get; set; }
        public int RentId { get; set; }




        public Rent Rent { get; set; }
    }
}
