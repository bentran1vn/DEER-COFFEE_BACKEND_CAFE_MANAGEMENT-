using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.GetAll
{
    public class GetAllEmployeeShiftQuery : IRequest<List<EmployeeShiftDto>>, IQuery
    {
        public GetAllEmployeeShiftQuery() { }
    }
}
