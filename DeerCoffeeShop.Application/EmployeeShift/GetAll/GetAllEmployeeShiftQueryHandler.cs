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

namespace DeerCoffeeShop.Application.EmployeeShift.GetAll
{
    public class GetAllEmployeeShiftQueryHandler : IRequestHandler<GetAllEmployeeShiftQuery, List<EmployeeShiftDto>>
    {
        private readonly IEmployeeShiftRepository _employeeShiftRepository;
        private readonly IMapper _mapper;
        
        public GetAllEmployeeShiftQueryHandler(IEmployeeShiftRepository employeeShiftRepository, IMapper mapper)
        {
            _employeeShiftRepository = employeeShiftRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeShiftDto>> Handle(GetAllEmployeeShiftQuery query, CancellationToken cancellationToken)
        {
            var list = await _employeeShiftRepository.FindAllAsync(x => (x.NguoiXoaID == null && x.NgayXoa == null) || !x.IsDeleted, cancellationToken);
            if (list.Count == 0)
                throw new NotFoundException("None employee shift was found!");
            return list.MapToListEmployeeShiftDto(_mapper);
        }
    }
}
