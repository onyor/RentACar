namespace Entities.Concrete.Identity
{
    public class UserOperationClaim : BaseEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }


        // NAV properties
        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
