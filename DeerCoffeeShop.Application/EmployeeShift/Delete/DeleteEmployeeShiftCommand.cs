using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Security;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.Delete
{
    [Authorize]
    public class DeleteEmployeeShiftCommand(string employeeID, string restaurantID, int shiftID) : IRequest<string>, ICommand
    {
        public string EmployeeID { get; } = employeeID;
        public string RestaurantID { get; } = restaurantID;
        public int ShiftID { get; } = shiftID;
    }
}
