using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Common.Exceptions;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift.Create
{
    public class CreateShiftCommandHandler(IShiftRepostiry shiftRepostory, ICurrentUserService currentUserService) : IRequestHandler<CreateShiftCommand, string>
    {
        private readonly IShiftRepostiry _shiftRepostory = shiftRepostory;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<string> Handle(CreateShiftCommand request, CancellationToken cancellationToken)
        {
            var checkDuplicated = await _shiftRepostory.AnyAsync(x => x.Name.Equals(request.shift_name)
            || (x.ShiftStart.CompareTo(request.shift_start) == 0 && x.ShiftEnd.CompareTo(request.shift_end) == 0),
            cancellationToken);
            if (checkDuplicated)
                throw new DuplicatedObjectException("This shift has been exist");
            var shift = new Domain.Entities.Shift()
            {
                Name = request.shift_name,
                ShiftStart = request.shift_start,
                ShiftEnd = request.shift_end,
                ShiftDescription = request.shift_description,
                IsActive = true,
                NguoiTaoID = _currentUserService.UserId,
            };

            _shiftRepostory.Add(shift);

            return await _shiftRepostory.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Create shift successfully!" : "Create shift failed!";
        }
    }
}
