using project.web.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.web.Core.Context
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser, ApplicationRole, 
        Guid, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, 
        ApplicationRoleClaim, ApplicationUserToken>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
