using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                DeliveryDay = dateTime,
                CustomerId = 1,
                RentBeginDate = dateTime,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Rent
            {
                Id = 2,
                DeliveryDay = dateTime,
                CustomerId = 1,
                RentBeginDate = dateTime,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Rent
            {
                Id = 3,
                DeliveryDay = dateTime,
                CustomerId = 2,
                RentBeginDate = dateTime,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}
