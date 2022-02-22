using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.web.Core
{
    public class Constants
    {
        internal static class DatabaseConstants 
        {
            // conn string
            internal const string CONN_STRING_NAME = "CatholicRmsConnection";

            // schemas
            internal const string DATABASE_IDENTITY_SCHEMA = "identity";
            internal const string DATABASE_DEFAULT_SCHEMA = "rms";

            // Tables (Identity)
            internal const string TABLE_ROLE_CLAIMS = "RoleClaims";
            internal const string TABLE_ROLES = "Roles";
            internal const string TABLE_USER_CLAIMS = "UserClaims";
            internal const string TABLE_USERS = "Users";
            internal const string TABLE_USER_LOGINS = "UserLogins";
            internal const string TABLE_USER_ROLES = "UserRoles";
            internal const string TABLE_USER_TOKENS = "UserTokens";

            // Tables (rms)

        }
    }
}
