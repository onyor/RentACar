using System.Collections.Generic;

namespace Entities.Concrete.Identity
{
    public class OperationClaim : BaseEntity
    {
        public string Name { get; set; }


        // NAV properties
        public List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
