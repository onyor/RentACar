using System.Collections.Generic;

namespace Entities.Concrete.Identity
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }


        // NAV properties
        public List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
