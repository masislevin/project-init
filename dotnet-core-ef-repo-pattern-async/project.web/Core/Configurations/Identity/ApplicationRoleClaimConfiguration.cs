using project.web.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static project.web.Core.Constants;

namespace project.web.Core.Configurations.Identity
{
    public class ApplicationRoleClaimConfiguration : IEntityTypeConfiguration<ApplicationRoleClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
        {
            builder.ToTable(DatabaseConstants.TABLE_ROLE_CLAIMS, DatabaseConstants.DATABASE_IDENTITY_SCHEMA);
        }
    }
}
