using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Update
{
    public class UpdateShiftCommand() : IRequest<string>, ICommand
    {
        public required int shift_id { get; set; }

        public string? shift_name { get; set; }

        public DateTime shift_start { get; set; }

        public DateTime shift_end { get; set; }

        public string? shift_description { get; set; }

    }
}
