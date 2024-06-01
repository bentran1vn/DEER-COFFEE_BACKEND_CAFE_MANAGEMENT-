using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeerCoffeeShop.Domain.Common.Exceptions;
using AutoMapper;

namespace DeerCoffeeShop.Application.EmployeeShift.GetByEmployeeId
{
    public class GetEmployeeShiftByEmployeeIdHandler(IEmployeeShiftRepository employeeShiftRepository, IMapper mapper) : IRequestHandler<GetEmployeeShiftByEmployeeIdQuery, PagedResult<EmployeeShiftDto>>
    {
        private readonly IEmployeeShiftRepository _employeeShiftRepository = employeeShiftRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<PagedResult<EmployeeShiftDto>> Handle(GetEmployeeShiftByEmployeeIdQuery query, CancellationToken cancellationToken)
        {
            var list = await _employeeShiftRepository.FindAllAsync(x => x.EmployeeID.Equals(query.EmployeeId) && x.NgayXoa == null, query.PageNo, query.PageSize, cancellationToken);

            if (list == null)
                throw new NotFoundException("Shift of this employee was not found!");

            return PagedResult<EmployeeShiftDto>.Create
                (
                    totalCount: list.TotalCount,
                    pageCount: list.PageCount,
                    pageSize: query.PageSize,
                    pageNumber: query.PageNo,
                    data: list.MapToListEmployeeShiftDto(_mapper)
                );
        }
    }
}
