using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Application.Common.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeerCoffeeShop.Domain.Common.Exceptions;

namespace DeerCoffeeShop.Application.EmployeeShift.Delete
{
    public class DeleteEmployeeShiftCommandHandler : IRequestHandler<DeleteEmployeeShiftCommand, string>
    {
        private readonly IEmployeeShiftRepository _employeeShiftRepository;
        private readonly ICurrentUserService _currentUserService;

        public DeleteEmployeeShiftCommandHandler(IEmployeeShiftRepository employeeShiftRepository, ICurrentUserService currentUserService)
        {
            _employeeShiftRepository = employeeShiftRepository;
            _currentUserService = currentUserService;
        }

        public async Task<string> Handle(DeleteEmployeeShiftCommand request, CancellationToken cancellationToken)
        {
            var foundObject = await _employeeShiftRepository.FindAsync(x => x.EmployeeID.Equals(request.EmployeeID)
            && x.RestaurantID.Equals(request.RestaurantID)
            && x.ShiftID == request.ShiftID
            && (x.NguoiXoaID == null || x.IsDeleted == true)) ?? throw new NotFoundException("Không tìm thấy ca trực của nhân viên thuộc cửa hàng");

            foundObject.NguoiXoaID = _currentUserService.UserId;
            foundObject.NgayXoa = DateTime.Now;
            foundObject.IsDeleted = true;
            _employeeShiftRepository.Update(foundObject);

            return await _employeeShiftRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Xóa thành công" : "Xóa thất bại";
        }
    }
}
