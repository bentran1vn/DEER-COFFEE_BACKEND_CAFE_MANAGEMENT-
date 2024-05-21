using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Authentication.LoginQuery;

public record LoginQuery(int EmployeeID, string Password) : IRequest<LoginDTO>, IQuery
{
    public int EmployeeID { get; } = EmployeeID;
    public string Password { get; } = Password;


}
