using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Domain.Entities.Base;
using MediatR;

namespace DeerCoffeeShop.Application.Authentication.Refrestoken.GenerateRefreshToken
{
    public class RefreshTokenCommand : IRequest<RefreshToken>, ICommand
    {

    }
}
