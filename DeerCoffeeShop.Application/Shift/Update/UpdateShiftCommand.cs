using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Update
{
    public class UpdateShiftCommand : IRequest<string>, ICommand
    {
        public UpdateShiftCommand() { }

        public UpdateShiftCommand(string shiftName, DateTime shiftStart, DateTime shiftEnd, string shiftDescription)
        {
            ShiftName = shiftName;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            ShiftDescription = shiftDescription;
        }

        public required int ShiftId { get; set; }

        public string? ShiftName { get; set; }

        public DateTime ShiftStart { get; set; }

        public DateTime ShiftEnd { get; set; }

        public string? ShiftDescription { get; set; }
    }
}
