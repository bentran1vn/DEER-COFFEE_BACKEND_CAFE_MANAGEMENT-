using AutoMapper;
using DeerCoffeeShop.Domain.Common.Exceptions;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.GetAll
{
    public class GetAllShiftQueryHandler : IRequestHandler<GetAllShiftQuery, List<ShiftDto>>
    {
        private readonly IShiftRepostiry _shiftRepository;
        private readonly IMapper _mapper;
        public GetAllShiftQueryHandler(IShiftRepostiry shiftRepository, IMapper mapper)
        {
            _shiftRepository = shiftRepository;
            _mapper = mapper;
        }

        public async Task<List<ShiftDto>> Handle(GetAllShiftQuery query, CancellationToken cancellationToken)
        {
            var shiftList = await _shiftRepository.FindAllAsync(x => x.IsActive == true, cancellationToken);
            if (shiftList.Count == 0)
                throw new NotFoundException("None shift was found!");
            return shiftList.MapToShiftDtoList(_mapper);
        }
    }
}
