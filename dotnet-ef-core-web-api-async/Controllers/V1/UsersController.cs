using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_web_api_async.Controllers.V1
{
    [ApiVersion("1.0")] 
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        /// <summary>
        /// Retrieves the details for the current authenticated user.
        /// </summary>
        /// <remarks>
        /// This endpoint is part of the V2 transition. 
        /// It returns a greeting message along with the identity name extracted from the JWT token.
        /// </remarks>
        /// <returns>A JSON object containing a message and the user's name.</returns>
        /// <response code="200">Returns the user identity details successfully.</response>
        /// <response code="401">If the JWT token is missing, expired, or invalid.</response>
        /// <response code="404">If the user resource could not be found.</response>
        /// <response code="500">If there was an internal server error processing the request.</response>
        [HttpGet]
        [HttpGet]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(void), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(void), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(void), StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is V1 of the Users API", User = User.Identity?.Name });
        }
    }
}
