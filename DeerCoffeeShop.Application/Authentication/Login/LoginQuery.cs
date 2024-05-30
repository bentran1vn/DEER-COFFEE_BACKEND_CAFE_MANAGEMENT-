using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;

namespace DeerCoffeeShop.Application.Authentication.Login;

public record LoginQuery(int EmployeeID, string Password) : IRequest<LoginDTO>, IQuery
{
    public int EmployeeID { get; } = EmployeeID;
    public string Password { get; } = Password;


}
