using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Domain.Entities;
using MediatR;

namespace DeerCoffeeShop.Application.Employees
{
    public class GetAllEmployeeQuery : IRequest<PagedResult<Employee>>, IQuery
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllEmployeeQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public GetAllEmployeeQuery() { }
    }
};


