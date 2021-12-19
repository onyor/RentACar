using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Car : BaseEntity
    {
        public string PlateNo { get; set; }
        public string Color { get; set; }
        public int BrandId { get; set; }
        public int Price { get; set; }
        public Brand Brand { get; set; }
        public List<RentCar> RentCars { get; set; }
    }
}
