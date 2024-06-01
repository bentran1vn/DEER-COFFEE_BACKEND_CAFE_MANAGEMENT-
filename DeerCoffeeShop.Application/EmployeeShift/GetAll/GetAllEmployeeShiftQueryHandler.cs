using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Application.Common.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeerCoffeeShop.Domain.Common.Exceptions;
using AutoMapper;
using DeerCoffeeShop.Application.Common.Pagination;

namespace DeerCoffeeShop.Application.EmployeeShift.GetAll
{
    public class GetAllEmployeeShiftQueryHandler(IEmployeeShiftRepository employeeShiftRepository, IMapper mapper) : IRequestHandler<GetAllEmployeeShiftQuery, PagedResult<EmployeeShiftDto>>
    {
        private readonly IEmployeeShiftRepository _employeeShiftRepository = employeeShiftRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<PagedResult<EmployeeShiftDto>> Handle(GetAllEmployeeShiftQuery query, CancellationToken cancellationToken)
        {
            var list = await _employeeShiftRepository.FindAllAsync(x => (x.NguoiXoaID == null && x.NgayXoa == null) || !x.IsDeleted,query.PageNumber, query.PageSize, cancellationToken);
            if (list.TotalCount == 0)
                throw new NotFoundException("None employee shift was found!");
            return PagedResult<EmployeeShiftDto>.Create
                (
                    totalCount: list.TotalCount,
                    pageCount: list.PageCount,
                    pageSize: query.PageSize,
                    pageNumber: query.PageNumber,
                    data: list.MapToListEmployeeShiftDto(_mapper)
                );
        }
    }
}
