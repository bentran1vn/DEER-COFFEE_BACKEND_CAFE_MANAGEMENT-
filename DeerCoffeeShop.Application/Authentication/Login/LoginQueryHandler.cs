using AutoMapper;
using DeerCoffeeShop.Domain.Common.Exception;
using DeerCoffeeShop.Domain.Common.Exceptions;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Authentication.LoginQuery
{
    internal class LoginQueryHandler(IEmployeeRepository _employeeRepository) : IRequestHandler<LoginQuery, LoginDTO>
    {
        public async Task<LoginDTO> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _employeeRepository.FindAsync(_ => _.EmployeeID == request.EmployeeID && _.NgayXoa == null, cancellationToken) ?? throw new NotFoundException("User not found");
            var isTrue = _employeeRepository.VerifyPassword(request.Password, user.Password);
            if (!isTrue)
            {
                throw new IncorrectPasswordException("Password is incorrect");
            }

            return LoginDTO.Create(user.EmployeeID, user.RoleID);
        }
    }
}
