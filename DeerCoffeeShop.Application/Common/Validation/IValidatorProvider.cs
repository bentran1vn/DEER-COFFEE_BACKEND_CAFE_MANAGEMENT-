using FluentValidation;

namespace DeerCoffeeShop.Application.Common.Validation
{
    public interface IValidatorProvider
    {
        IValidator<T> GetValidator<T>();
    }
}
