using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class RentCar : IEntity
    {
        public int CarId { get; set; }
        public int RentId { get; set; }

        public Car Car { get; set; }
        public Rent Rent { get; set; }
    }
}
