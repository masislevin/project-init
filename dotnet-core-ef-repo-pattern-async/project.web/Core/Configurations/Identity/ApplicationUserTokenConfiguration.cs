using project.web.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static project.web.Core.Constants;

namespace project.web.Core.Configurations.Identity
{
    public class ApplicationUserTokenConfiguration : IEntityTypeConfiguration<ApplicationUserToken>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
        {
            builder.ToTable(DatabaseConstants.TABLE_USER_TOKENS, DatabaseConstants.DATABASE_IDENTITY_SCHEMA);
        }
    }
}
