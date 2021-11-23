using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);

            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Customer
            {
                Id = 1,
                Address = "Ergazi Mah",
                Name="Onur",
                Surname="Yıldız",
                Phone="5845844595",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Customer
            {
                Id = 2,
                Address = "Bent Deresi",
                Name = "Muhammed",
                Surname = "Yazıcı",
                Phone = "5485648546",
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}
