using Ecom.API.Helper;
using System.Net;

namespace Ecom.API.MiddleWare
{
    public class ExcptionsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHostEnvironment _environment;

        public ExcptionsMiddleware(RequestDelegate next, IHostEnvironment environment)
        {
            _next = next;
            _environment = environment;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

             context.Response.StatusCode =(int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var response = _environment.IsDevelopment() ?   // in development mode show the details of the exception
                   new ApiExcptions((int)HttpStatusCode.InternalServerError, ex.Message, ex.StackTrace)
                    : new ApiExcptions((int)HttpStatusCode.InternalServerError, ex.Message);

                var json = System.Text.Json.JsonSerializer.Serialize(response);   // serialize the response object to json format
                await context.Response.WriteAsync(json);


            }
        }
    }
}