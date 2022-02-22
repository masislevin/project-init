using Microsoft.AspNetCore.Identity;
using System;

namespace project.web.Core.Entities.Identity
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        //public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        //public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public string Description { get; set; }
    }
}
