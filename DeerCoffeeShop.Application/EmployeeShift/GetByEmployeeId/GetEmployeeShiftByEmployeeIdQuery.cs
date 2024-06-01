using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Pagination;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift.GetByEmployeeId
{
    public class GetEmployeeShiftByEmployeeIdQuery(string employee_id, int page_size, int page_no) : IRequest<PagedResult<EmployeeShiftDto>>, IQuery
    {
        public string? EmployeeId { get; } = employee_id;

        public int PageSize { get; } = page_size;

        public int PageNo { get; } = page_no;

    }
}
