using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DeerCoffeeShop.Application.Shift.Create
{
    public class CreateShiftCommandValidator : AbstractValidator<CreateShiftCommand>
    {
        public CreateShiftCommandValidator() 
        {
            Configure();
        }

        public void Configure()
        {
            RuleFor(x => x.shift_end.Hour)
                 .GreaterThan(x => x.shift_start.Hour)
                 .WithMessage("Shift end must later than shift start!");

            RuleFor(x => x.shift_start.Day.CompareTo(x.shift_end.Day))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.shift_start.Month.CompareTo(x.shift_end.Month))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.shift_start.Year.CompareTo(x.shift_end.Year))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.shift_start)
                .NotNull()
                .NotEmpty()
                .WithMessage("Shift's start times must not be empty!");

            RuleFor(x => x.shift_end)
                .NotNull()
                .NotEmpty()
                .WithMessage("Shift's end times must not be empty!");

            RuleFor(x => x.shift_name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Shift's name must not be empty!");

            RuleFor(x => x.shift_description)
                .NotEmpty()
                .NotNull()
                .WithMessage("Shift's description must not be empty!");
        }
    }
}
