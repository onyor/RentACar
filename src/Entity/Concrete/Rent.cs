using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rent : BaseEntity
    {
        public int RentId { get; set; }
        public int PlateNo { get; set; }
        public DateTime DeliveryDay { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentBeginDate { get; set; }
    }
}
