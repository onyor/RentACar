using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");

            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Brand
            {
                Id = 1,
                Name = "Mercedes",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Brand
            {
                Id = 2,
                Name = "BMW",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Brand
            {
                Id = 3,
                Name = "TOGG",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Brand
            {
                Id = 4,
                Name = "Porsche",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}