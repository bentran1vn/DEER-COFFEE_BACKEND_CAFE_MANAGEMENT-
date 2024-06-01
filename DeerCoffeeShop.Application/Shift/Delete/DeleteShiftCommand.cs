using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Security;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Delete
{
    [Authorize]
    public class DeleteShiftCommand(int id) : IRequest<string>, ICommand
    {
        public int Id { get; } = id; 
    }
}
