using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : BaseEntity
    {
        public string PlateNo { get; set; }
        public string Color { get; set; }
        //[ForeignKey("Brand")]
        public string BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<RentCar> RentCars { get; set; }
    }
}
