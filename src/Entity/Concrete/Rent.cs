using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rent : BaseEntity
    {
        public int PlateNo { get; set; }
        public DateTime DeliveryDay { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentBeginDate { get; set; }
        public Invoice Invoice { get; set; }
        public List<RentCar> RentCars { get; set; }
    }
}
