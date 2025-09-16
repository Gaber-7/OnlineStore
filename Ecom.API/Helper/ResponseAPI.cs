namespace Ecom.API.Helper
{
    public class ResponseAPI
    {
        public ResponseAPI(int statusCode, string? message = null )
        {
            StatusCode = statusCode;
            Message = message ?? GetMessageStatusCode(statusCode);
        }
        private string GetMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                200 => "Done",
                400 => "Bad Request",
                401 => "Un Authorized",
                500 => "Server error",
                _=> "Null",
            };
         }

        public int StatusCode { get; set; } 
        public string? Message { get; set; }
        
    }
}
