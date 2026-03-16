using dotnet_ef_core_web_api_async.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace dotnet_ef_core_web_api_async.Extensions
{
    public class ApiVersionExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ApiVersionUnspecifiedException)
            {
                context.Result = new BadRequestObjectResult(new
                {
                    error = "API version is required",
                    supportedVersions = new[] { "1.0", "2.0" }
                });
                context.ExceptionHandled = true;
            }
        }
    }
}
