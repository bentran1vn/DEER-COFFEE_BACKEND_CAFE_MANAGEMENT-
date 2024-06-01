using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift
{
    public static class ShiftDtoMappingExtension
    {
        public static ShiftDto MapToShiftDto(this Domain.Entities.Shift form, IMapper mapper)
            => mapper.Map<ShiftDto>(form);

        public static List<ShiftDto> MapToShiftDtoList(this IEnumerable<Domain.Entities.Shift> form, IMapper mapper) 
            => form.Select(x => x.MapToShiftDto(mapper)).ToList();
    }
}
