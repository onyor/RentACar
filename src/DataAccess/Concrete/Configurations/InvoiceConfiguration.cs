using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");
            builder.HasKey(x => x.Id);

            var dateTime = new DateTime(2021, 1, 1);

            builder.HasData(new Invoice
            {
                Id = 1,
                RentMoney = 50,
                Date = dateTime,
                RentId = 1,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Invoice
            {
                Id = 2,
                RentMoney = 150,
                Date = dateTime,
                RentId = 2,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });

            builder.HasData(new Invoice
            {
                Id = 3,
                RentMoney = 250,
                Date = dateTime,
                RentId = 3,
                CreatedAt = dateTime,
                CreatedBy = Guid.Empty,
                IsActive = true,
                IsDeleted = false
            });
        }
    }
}