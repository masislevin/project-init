using dotnet_ef_core_web_api_async.Services.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace dotnet_ef_core_web_api_async.Services
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IConfiguration _configuration;

        public TokenProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ClearToken()
        {
            throw new NotImplementedException();
        }

        public ClaimsPrincipal? CreatePrincipalFromJwtToken(string token)
        {
            throw new NotImplementedException();
        }

        public string? GetAccessToken()
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt")["Secret"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "TestUser") }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = "https://localhost:7127", /// get from config
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
             
            return tokenHandler.WriteToken(token);
        }

        public string? GetRefreshToken()
        {
            throw new NotImplementedException();
        }

        public void SetToken(string accessToken, string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
