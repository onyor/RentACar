﻿using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class RentCarConfiguration : IEntityTypeConfiguration<RentCar>
    {
        public void Configure(EntityTypeBuilder<RentCar> builder)
        {
            builder.ToTable("RentCar");
            builder.HasIndex(x => new { x.RentId, x.CarId }).IsUnique();
        }
    }
}