using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.GetAll
{
    public class GetAllEmployeeShiftQueryValidator : AbstractValidator<GetAllEmployeeShiftQuery>
    {
        public GetAllEmployeeShiftQueryValidator() 
        {
            Configure();
        }

        public void Configure()
        {
            RuleFor(x => x.PageNumber)
                .NotNull()
                .NotEmpty()
                .WithMessage("Page number must not be null!");

            RuleFor(x => x.PageSize)
                .NotNull()
                .NotEmpty()
                .WithMessage("Page size must not be null!");
        }
    }
}
