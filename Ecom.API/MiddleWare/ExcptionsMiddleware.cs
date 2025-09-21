namespace Ecom.API.MiddleWare
{
    public class ExcptionsMiddleware
    {
        private readonly RequestDelegate _next;

        public ExcptionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                //context.Response.StatusCode = 500; // Internal Server Error
                //context.Response.ContentType = "application/json";
                //var response = new
                //{
                //    StatusCode = context.Response.StatusCode,
                //    Message = "An unexpected error occurred.",
                //    Detailed = ex.Message // In production, avoid exposing detailed error messages
                //};
                //var jsonResponse = System.Text.Json.JsonSerializer.Serialize(response);
                //await context.Response.WriteAsync(jsonResponse);
            }
        }
    }
}