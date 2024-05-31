using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Application.Common.Security;
using DeerCoffeeShop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.GetAll
{
    [Authorize]
    public class GetAllShiftQuery(int pageNo, int pageSize) : IRequest<PagedResult<ShiftDto>>, IQuery
    {
        public int PageNo { get; } = pageNo;

        public int PageSize { get; } = pageSize;
    }
}
