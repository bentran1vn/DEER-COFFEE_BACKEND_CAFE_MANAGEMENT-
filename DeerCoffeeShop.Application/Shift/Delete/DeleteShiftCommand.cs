using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Delete
{
    public class DeleteShiftCommand : IRequest<string>, ICommand
    {
        public DeleteShiftCommand() { }

        public DeleteShiftCommand(int id) 
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
