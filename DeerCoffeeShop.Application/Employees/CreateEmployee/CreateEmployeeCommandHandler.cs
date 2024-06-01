using System.Dynamic;
using DeerCoffeeShop.Domain.Common.Exceptions;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using MediatR;

namespace DeerCoffeeShop.Application.Employees.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRoleRepository _roleRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IRoleRepository roleRepository)
        {
            _employeeRepository = employeeRepository;
            _roleRepository = roleRepository;
        }

        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            dynamic errorData = new ExpandoObject();
            var isExistEmail = await _employeeRepository.AnyAsync(x => x.Email == request.Email);
            if (isExistEmail) errorData.Email = "Email already exist !";

            var isValidPhoneNumber = request.PhoneNumber.Length < 10 || request.PhoneNumber.Length > 12;
            if (isValidPhoneNumber) errorData.PhoneNumber = "Phone number must in range 10 to 12 !";

            var isExistPhone = await _employeeRepository.AnyAsync(x => x.PhoneNumber == request.PhoneNumber);
            if (isExistPhone && !isValidPhoneNumber) errorData.PhoneNumber = "Phone already exist !";

            if (isExistEmail || isValidPhoneNumber || isExistPhone)
            {
                throw new FormException("Error in creating employee", errorData);
            }
            var emp = new Employee
            {
                Address = request.Address,
                DateOfBirth = DateTime.Parse(request.DateOfBirth),
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                RoleID = 3,
                IsActive = false
            };
            _employeeRepository.Add(emp);
            await _employeeRepository.UnitOfWork.SaveChangesAsync();
            return "OK";
        }
    }
};


