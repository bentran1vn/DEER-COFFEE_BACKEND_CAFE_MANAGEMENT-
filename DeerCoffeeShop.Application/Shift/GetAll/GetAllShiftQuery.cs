using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.GetAll
{
    public class GetAllShiftQuery : IRequest<List<ShiftDto>>, IQuery
    {
        public GetAllShiftQuery() { }
    }
}
