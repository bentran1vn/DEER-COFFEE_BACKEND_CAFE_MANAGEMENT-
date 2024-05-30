using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeerCoffeeShop.Domain.Common.Exceptions;

namespace DeerCoffeeShop.Application.Shift.Update
{
    public class UpdateShiftCommandHandler : IRequestHandler<UpdateShiftCommand, string>
    {
        private readonly IShiftRepostiry _shiftRepository;
        private readonly ICurrentUserService _currentUserService;

        public UpdateShiftCommandHandler(IShiftRepostiry shiftRepository, ICurrentUserService currentUserService)
        {
            _shiftRepository = shiftRepository;
            _currentUserService = currentUserService;
        }

        public async Task<string> Handle(UpdateShiftCommand request, CancellationToken cancellationToken)
        {
            var foundObject = await _shiftRepository.FindAsync(x => x.ID == request.ShiftId, cancellationToken);
            if (foundObject == null)
                throw new NotFoundException("None shift was found!");
            foundObject.Name = request.ShiftName ?? foundObject.Name;
            foundObject.ShiftStart = request.ShiftStart;
            foundObject.ShiftEnd = request.ShiftEnd;
            foundObject.ShiftDescription = request.ShiftDescription ?? foundObject.ShiftDescription;
            foundObject.NguoiCapNhatID = _currentUserService.UserId;
            foundObject.NgayCapNhat = DateTime.Now;

            _shiftRepository.Update(foundObject);
            return await _shiftRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Update shift successfully!" : "Update shift failed!";
        }
    }
}
