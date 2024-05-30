using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.Delete
{
    public class DeleteEmployeeShiftCommand : IRequest<string>, ICommand
    {
        public string EmployeeID { get; set; }
        public string RestaurantID { get; set; }
        public int ShiftID { get; set; }

        public DeleteEmployeeShiftCommand() { }

        public DeleteEmployeeShiftCommand(string employeeID, string restaurantID, int shiftID)
        {
            EmployeeID = employeeID;
            RestaurantID = restaurantID;
            ShiftID = shiftID;
        }
    }
}
