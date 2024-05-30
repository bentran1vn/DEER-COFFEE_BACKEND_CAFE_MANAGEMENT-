using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.Delete
{
    public class DeleteEmployeeShiftCommandValidator : AbstractValidator<DeleteEmployeeShiftCommand>
    {
        public DeleteEmployeeShiftCommandValidator() 
        {
            Configure();
        }

        public void Configure()
        {
            RuleFor(x => x.EmployeeID)
                .NotEmpty()
                .NotNull()
                .WithMessage("Employee must not be empty!");

            RuleFor(x => x.RestaurantID)
                .NotEmpty()
                .NotNull()
                .WithMessage("Restaurant must not be empty!");

            RuleFor(x => x.ShiftID)
                .NotEmpty()
                .NotNull()
                .WithMessage("Shift must not be empty!");
        }
    }
}
