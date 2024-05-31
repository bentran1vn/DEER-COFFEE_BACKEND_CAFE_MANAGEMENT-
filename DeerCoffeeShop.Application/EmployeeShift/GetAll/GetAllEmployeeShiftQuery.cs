using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Application.Common.Security;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.GetAll
{
    [Authorize]
    public class GetAllEmployeeShiftQuery(int pageNo, int pageSize) : IRequest<PagedResult<EmployeeShiftDto>>, IQuery
    {
        public int PageNumber { get; } = pageNo;
        public int PageSize { get; } = pageSize;
    }
}
