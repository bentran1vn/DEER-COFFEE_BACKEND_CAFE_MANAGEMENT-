using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.GetByEmployeeId
{
    public class GetEmployeeShiftByEmployeeIdValidator : AbstractValidator<GetEmployeeShiftByEmployeeIdQuery>
    {
        public GetEmployeeShiftByEmployeeIdValidator() 
        {
            Configure();
        }

        public void Configure()
        {
            RuleFor(x => x.EmployeeId)
                .NotNull()
                .NotEmpty()
                .WithMessage("Employee must be not empty!");

            RuleFor(x => x.PageNo)
               .NotNull()
               .NotEmpty()
               .WithMessage("Page number must be not empty!");

            RuleFor(x => x.EmployeeId)
               .NotNull()
               .NotEmpty()
               .WithMessage("Page size must be not empty!");
        }
    }
}
