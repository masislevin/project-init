using Microsoft.AspNetCore.Identity;
using System;

namespace project.web.Core.Entities.Identity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        //public virtual ApplicationRole Role { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
