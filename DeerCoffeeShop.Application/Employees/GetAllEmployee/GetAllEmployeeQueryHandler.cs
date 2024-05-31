using AutoMapper;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;

namespace DeerCoffeeShop.Application.Employees
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, PagedResult<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<PagedResult<Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var list = await _employeeRepository.FindAllAsync(request.PageNumber, request.PageSize, cancellationToken);
            // var list = await _nhanvienRepository.FindAllAsync(_ => _.NgayXoa == null, request.PageNumber, request.PageSize, cancellationToken);
            // var chucvu = await _chucVuRepository.FindAllToDictionaryAsync(x => x.NgayXoa == null, x => x.ID, x => x.Name, cancellationToken);
            // var tinhtranglamviec = await _tinhTrangLamViecRepository.FindAllToDictionaryAsync(x => x.NgayXoa == null, x => x.ID, x => x.Name, cancellationToken);
            // var returnList = list.MapToNhanVienDtoList(_mapper, chucvu, tinhtranglamviec, null);

            return PagedResult<Employee>.Create(totalCount: list.TotalCount,
                               pageCount: list.PageCount,
                                              pageSize: list.PageSize,
                                                             pageNumber: list.PageNo,
                                                                            data: list);
        }
    }
}