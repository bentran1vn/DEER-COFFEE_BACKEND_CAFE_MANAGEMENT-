namespace DeerCoffeeShop.Domain.Common.Exceptions
{
    public class DuplicatedObjectException : SystemException
    {
        public DuplicatedObjectException(string message) : base(message) { } 
    }
}
