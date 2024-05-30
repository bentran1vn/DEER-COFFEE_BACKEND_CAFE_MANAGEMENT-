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
    public class CreateShiftCommandHandler : IRequestHandler<CreateShiftCommand, string>
    {
        private readonly IShiftRepostiry _shiftRepostory;
        private readonly ICurrentUserService _currentUserService;

        public CreateShiftCommandHandler(IShiftRepostiry shiftRepostory, ICurrentUserService currentUserService)
        {
            _shiftRepostory = shiftRepostory;
            _currentUserService = currentUserService;
        }

        public async Task<string> Handle(CreateShiftCommand request, CancellationToken cancellationToken)
        {
            var checkDuplicated = await _shiftRepostory.AnyAsync(x => x.Name.Equals(request.ShiftName)
            || x.ShiftStart.CompareTo(request.ShiftStart) == 0
            || x.ShiftStart.CompareTo(request.ShiftEnd) == 0,
            cancellationToken);
            if (checkDuplicated)
                throw new DuplicatedObjectException("This shift has been exist");
            var shift = new Domain.Entities.Shift()
            {
                Name = request.ShiftName,
                ShiftStart = request.ShiftStart,
                ShiftEnd = request.ShiftEnd,
                ShiftDescription = request.ShiftDescription,
                IsActive = true,
                NguoiTaoID = _currentUserService.UserId,
                NgayTao = DateTime.Now
            };

            _shiftRepostory.Add(shift);

            return await _shiftRepostory.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Create shift successfully!" : "Create shift failed!";
        }
    }
}
