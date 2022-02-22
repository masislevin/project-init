using project.web.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static project.web.Core.Constants;

namespace project.web.Core.Configurations.Identity
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.ToTable(DatabaseConstants.TABLE_USER_ROLES, DatabaseConstants.DATABASE_IDENTITY_SCHEMA);
        }
    }
}
