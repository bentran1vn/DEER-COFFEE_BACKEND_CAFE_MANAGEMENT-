using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Security;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Create
{
    [Authorize]
    public class CreateShiftCommand() : IRequest<string>, ICommand
    {

        public required string shift_name { get; set; }

        public required DateTime shift_start {  get; set; }

        public required DateTime shift_end {  get; set; }

        public required string shift_description {  get; set; }
    }
}
