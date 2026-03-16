using dotnet_ef_core_web_api_async.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_web_api_async.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly ITokenProvider _tokenProvider;

        public AuthController(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider; 
        }

        /// <summary>
        /// FOR TESTING ONLY
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAccessToken()
        {
            return Ok(_tokenProvider.GetAccessToken());
        }
    }
}
