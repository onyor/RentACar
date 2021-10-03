using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Earning : BaseEntity
    {
        public int CarId { get; set; }
        public decimal RentMoney { get; set; }
        public DateTime Date { get; set; }
        public string PlateNo { get; set; }
    }
}
