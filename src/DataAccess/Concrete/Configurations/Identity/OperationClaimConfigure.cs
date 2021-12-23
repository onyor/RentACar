using Entities.Concrete.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations.Identity
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.ToTable("OperationClaims");
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
