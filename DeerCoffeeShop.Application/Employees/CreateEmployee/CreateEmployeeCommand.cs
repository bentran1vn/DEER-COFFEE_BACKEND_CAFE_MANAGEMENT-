using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Domain.Entities;
using MediatR;

namespace DeerCoffeeShop.Application.Employees.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<string>, ICommand
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public CreateEmployeeCommand(string fullname, string email, string date_of_birth, string phone_number, string address)
        {
            FullName = fullname;
            Email = email;
            DateOfBirth = date_of_birth;
            PhoneNumber = phone_number;
            Address = address;
        }

        public CreateEmployeeCommand() { }
    }
};


