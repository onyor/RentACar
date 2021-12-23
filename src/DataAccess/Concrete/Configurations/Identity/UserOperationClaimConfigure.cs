using Entities.Concrete.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations.Identity
{
    public class UserOperationClaimConfigure : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.ToTable("UserOperationClaims");
            builder.Property(c => c.UserId)
                .IsRequired();
            builder.Property(c => c.OperationClaimId)
                .IsRequired();
        }
    }
}
