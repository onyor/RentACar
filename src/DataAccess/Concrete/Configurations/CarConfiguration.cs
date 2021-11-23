using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);

            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Car
            {
                Id = 1,
                PlateNo = "06 CJF 117",
                Color= "Kırmızı",
                BrandId=1,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Car
            {
                Id = 2,
                PlateNo = "06 ABC 123",
                Color = "Siyah",
                BrandId = 2,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Car
            {
                Id = 3,
                PlateNo = "08 LAZ 999",
                Color = "Yeşil",
                BrandId = 3,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}
