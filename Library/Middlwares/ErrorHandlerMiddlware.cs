using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Library.Exceptions;

namespace Library.Middlwares
{
    public class ErrorHandlerMiddlware
    {
        private readonly RequestDelegate next;

        public ErrorHandlerMiddlware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                if (context.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                    await HandleExceptionAsync(context, ex);
                else
                    throw;
            }


        }


        public static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var obj = JObject.FromObject(exception);
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = Convert.ToInt32(obj["StatusCode"] ?? 500);
            var Result =
                JsonConvert.SerializeObject(new AjaxException(httpContext.Response.StatusCode, exception.Message));

            return httpContext.Response.WriteAsync(Result);
        }

    }

    public static class ErrorHandlerMiddlwarePipeline
    {
        public static IApplicationBuilder UseErrorHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ErrorHandlerMiddlware>();
        }
    }

}
