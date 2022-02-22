using project.web.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static project.web.Core.Constants;

namespace project.web.Core.Configurations.Identity
{
    public class ApplicationUserLoginConfiguration : IEntityTypeConfiguration<ApplicationUserLogin>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserLogin> builder)
        {
            builder.ToTable(DatabaseConstants.TABLE_USER_LOGINS, DatabaseConstants.DATABASE_IDENTITY_SCHEMA);
        }
    }
}
