using System.Security.Claims;

namespace dotnet_ef_core_web_api_async.Services.Interface
{
    public interface ITokenProvider
    {
        void SetToken(string accessToken, string refreshToken);
        string? GetAccessToken();
        string? GetRefreshToken();
        void ClearToken();
        ClaimsPrincipal? CreatePrincipalFromJwtToken(string token);
    }
}
