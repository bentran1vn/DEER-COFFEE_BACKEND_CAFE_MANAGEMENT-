using AutoMapper;
using DeerCoffeeShop.Application.Common.Pagination;
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
    public class GetAllShiftQueryHandler(IShiftRepostiry shiftRepository, IMapper mapper) : IRequestHandler<GetAllShiftQuery, PagedResult<ShiftDto>>
    {
        private readonly IShiftRepostiry _shiftRepository = shiftRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<PagedResult<ShiftDto>> Handle(GetAllShiftQuery query, CancellationToken cancellationToken)
        {
            var shiftList = await _shiftRepository.FindAllAsync(x => x.IsActive == true, query.PageNo, query.PageSize, cancellationToken);
            if (shiftList.TotalCount == 0)
                throw new NotFoundException("None shift was found!");
            return PagedResult<ShiftDto>.Create
                (
                    totalCount: shiftList.TotalCount,
                    pageCount: shiftList.PageCount,
                    pageSize: query.PageSize,
                    pageNumber: query.PageNo,
                    data: shiftList.MapToShiftDtoList(_mapper)
                );
        }
    }
}
