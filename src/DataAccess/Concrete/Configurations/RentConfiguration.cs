using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.ToTable("Rent");
            builder.HasKey(x => x.Id);


            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Rent
            {
                Id = 1,
                PlateNo = "06 CJF 117",
                DeliveryDay = dateTime,
                CustomerId = 1,
                RentBeginDate = dateTime,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            }); ;
        }
    }
}
