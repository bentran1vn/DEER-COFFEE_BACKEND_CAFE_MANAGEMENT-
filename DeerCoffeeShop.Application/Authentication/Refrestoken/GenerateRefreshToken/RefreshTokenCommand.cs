using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Entities.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Authentication.Refrestoken.GenerateRefreshToken
{
    public class RefreshTokenCommand : IRequest<RefreshToken>, ICommand
    {

    }
}
