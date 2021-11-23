using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");
            builder.HasKey(x => x.Id);

            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Location
            {
                Id = 1,
                Phone = "5545874565",
                Address = "Atlantis AVM",
                CarId = 1,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Location
            {
                Id = 2,
                Phone = "5487985465",
                Address = "Ostim OSB",
                CarId = 2,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}
