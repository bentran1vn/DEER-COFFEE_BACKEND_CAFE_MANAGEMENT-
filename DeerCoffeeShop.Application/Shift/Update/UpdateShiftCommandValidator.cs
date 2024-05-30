using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Update
{
    public class UpdateShiftCommandValidator : AbstractValidator<UpdateShiftCommand>
    {
        public UpdateShiftCommandValidator() 
        {
            Configure();
        }

        public void Configure()
        {
            RuleFor(x => x.ShiftEnd.Hour)
                  .GreaterThan(x => x.ShiftStart.Hour)
                  .WithMessage("Shift end must later than shift start!");

            RuleFor(x => x.ShiftStart.Day.CompareTo(x.ShiftEnd.Day))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.ShiftStart.Month.CompareTo(x.ShiftEnd.Month))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.ShiftStart.Year.CompareTo(x.ShiftEnd.Year))
                .Equal(0)
                .WithMessage("Shift time is not illogical!");

            RuleFor(x => x.ShiftStart)
                .NotNull()
                .NotEmpty()
                .WithMessage("Shift's start times must not be empty!");

            RuleFor(x => x.ShiftEnd)
                .NotNull()
                .NotEmpty()
                .WithMessage("Shift's end times must not be empty!");

        }
    }
}
