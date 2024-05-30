namespace DeerCoffeeShop.Domain.Common.Exceptions;

public class IncorrectPasswordException(string message) : Exception(message)
{
}
