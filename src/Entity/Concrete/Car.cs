using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : BaseEntity
    {
        public int CarId { get; set; }
        public string PlateNo { get; set; }
        public string Color { get; set; }
        public decimal RentMoney { get; set; }
        public string Brand { get; set; }
        public int LocationId { get; set; }
        public int RentId { get; set; }
    }
}
