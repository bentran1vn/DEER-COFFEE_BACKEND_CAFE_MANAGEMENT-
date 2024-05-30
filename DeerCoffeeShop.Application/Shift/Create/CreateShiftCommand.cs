using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Create
{
    public class CreateShiftCommand : IRequest<string>, ICommand
    {
        public CreateShiftCommand() { }

        public CreateShiftCommand(string shiftName, DateTime shiftStart, DateTime shiftEnd, string shiftDescription)
        {
            ShiftName = shiftName;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            ShiftDescription = shiftDescription;
        }

        public required string ShiftName { get; set; }

        public required DateTime ShiftStart { get; set; }

        public required DateTime ShiftEnd { get; set; }

        public required string ShiftDescription { get; set; }
    }
}
