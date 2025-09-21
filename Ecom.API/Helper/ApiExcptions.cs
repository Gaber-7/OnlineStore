namespace Ecom.API.Helper
{
    public class ApiExcptions : ResponseAPI
    {
        public ApiExcptions(int statusCode, string? message = null , string details = null) : base(statusCode, message)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}
