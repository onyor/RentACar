using Core.Entities;

namespace Entity.Concrete
{
    public class RentCar : IEntity
    {
        public int CarId { get; set; }
        public int RentId { get; set; }


        // NAV properties
        public Car Car { get; set; }
        public Rent Rent { get; set; }
    }
}
