﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Invoice : BaseEntity
    {
        public float RentMoney { get; set; }
        public DateTime Date { get; set; }
        public string PlateNo { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        public virtual List<Car> Car { get; set; }
    }
}