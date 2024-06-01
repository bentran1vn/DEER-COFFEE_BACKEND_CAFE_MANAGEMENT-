namespace DeerCoffeeShop.Domain.Common.Exceptions
{
    public class FormException : Exception
    {
        public int StatusCode { get; }
        public object? DataError { get; }

        public FormException(string message, object? data = null, int statusCode = 422) : base(message)
        {
            StatusCode = statusCode;
            DataError = data;
        }
    }
}