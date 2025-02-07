



using Day8Assignment3._1.Middleware;

namespace Day8Assignment3._1.Middleware
{
    public class RequestLoggingMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            // Log incoming request details
            _logger.LogInformation($"Incoming Request: {context.Request.Method} {context.Request.Path}");

        

            // Store original response body reference
            var originalResponseBodyStream = context.Response.Body;

            try
            {
                // Capture the response using a MemoryStream
                using (var responseBody = new MemoryStream())
                {
                    context.Response.Body = responseBody;

                    await _next(context); // Call next middleware

                    // Log response status code
                    _logger.LogInformation($"Response Status: {context.Response.StatusCode}");

                    // Reset response body position and copy it back to original stream
                    responseBody.Seek(0, SeekOrigin.Begin);
                    await responseBody.CopyToAsync(originalResponseBodyStream);
                }
            }
            finally
            {
                context.Response.Body = originalResponseBodyStream;
            }
        }
    }
}


public static class RequestLoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestLoggingMiddleware>();
    }
}

