namespace Library.Exceptions
{
    public class AjaxException
    {
        public AjaxException(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }


        public int StatusCode { get; private set; }
        public string Message { get; private set; }
    }
}
