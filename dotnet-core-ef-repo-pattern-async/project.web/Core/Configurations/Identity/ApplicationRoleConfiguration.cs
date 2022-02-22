using project.web.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static project.web.Core.Constants;

namespace project.web.Core.Configurations.Identity
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.ToTable(DatabaseConstants.TABLE_ROLES, DatabaseConstants.DATABASE_IDENTITY_SCHEMA);
        }
    }
}
