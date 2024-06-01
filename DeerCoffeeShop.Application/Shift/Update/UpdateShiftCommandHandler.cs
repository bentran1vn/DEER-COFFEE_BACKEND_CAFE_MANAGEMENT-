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
    public class UpdateShiftCommandHandler(IShiftRepostiry shiftRepository, ICurrentUserService currentUserService) : IRequestHandler<UpdateShiftCommand, string>
    {
        private readonly IShiftRepostiry _shiftRepository = shiftRepository;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<string> Handle(UpdateShiftCommand request, CancellationToken cancellationToken)
        {
            var foundObject = await _shiftRepository.FindAsync(x => x.ID == request.shift_id, cancellationToken);
            if (foundObject == null)
                throw new NotFoundException("None shift was found!");
            foundObject.Name = request.shift_name ?? foundObject.Name;
            foundObject.ShiftStart = request.shift_start;
            foundObject.ShiftEnd = request.shift_end;
            foundObject.ShiftDescription = request.shift_description ?? foundObject.ShiftDescription;
            foundObject.NguoiCapNhatID = _currentUserService.UserId;
            foundObject.NgayCapNhat = DateTime.Now;

            _shiftRepository.Update(foundObject);
            return await _shiftRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Update shift successfully!" : "Update shift failed!";
        }
    }
}
