using Entities.Concrete.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations.Identity
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.PasswordHash)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(c => c.PasswordSalt)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(c => c.Status)
                .IsRequired();


            var dateTime = new DateTime(2021, 1, 1);

            //builder.HasData(new User
            //{
            //    Id = 1,
            //    FirstName = "Onur",
            //    CreatedAt = dateTime,
            //    CreatedBy = Guid.Empty,
            //    IsActive = true,
            //    IsDeleted = false
            //});

        }
    }
}
