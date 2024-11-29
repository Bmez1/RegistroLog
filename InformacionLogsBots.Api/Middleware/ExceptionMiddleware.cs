using InformacionLogsBots.Common.Interfaces;
using Newtonsoft.Json;
using System.Net;

namespace InformacionLogsBots.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IRegistroLogService logger)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                logger.Guardar(DateTime.UtcNow, DateTime.UtcNow, LogLevel.Error, $"Error general: {ex.Message}");
                await HandleExceptionAsync(httpContext);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var error = new
            {
                Code = context.Response.StatusCode,
                Message = "Error general"
            };

            var errorAString = JsonConvert.SerializeObject(error);

            return context.Response.WriteAsync(errorAString);
        }
    }
}
