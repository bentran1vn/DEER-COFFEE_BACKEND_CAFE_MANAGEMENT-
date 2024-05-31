using AutoMapper;
using DeerCoffeeShop.Application.Common.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift
{
    public static class EmployeeShiftDtoMappingExtension
    {
        public static EmployeeShiftDto MapToEmployeeShiftDto(this Domain.Entities.EmployeeShift form, IMapper mapper)
            => mapper.Map<EmployeeShiftDto>(form);

        public static List<EmployeeShiftDto> MapToListEmployeeShiftDto(this IEnumerable<Domain.Entities.EmployeeShift> form, IMapper mapper) 
            => form.Select(x => x.MapToEmployeeShiftDto(mapper)).ToList();
    }
}
