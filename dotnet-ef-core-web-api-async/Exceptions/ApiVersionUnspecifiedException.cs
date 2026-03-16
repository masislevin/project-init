using System.Net;

namespace dotnet_ef_core_web_api_async.Exceptions
{
    public class ApiVersionUnspecifiedException : Exception
    {
        public int StatusCode { get; } = (int)HttpStatusCode.BadRequest;

        public ApiVersionUnspecifiedException()
            : base("An API version must be specified in the request.") { }

        public ApiVersionUnspecifiedException(string message)
            : base(message) { }

        public ApiVersionUnspecifiedException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
