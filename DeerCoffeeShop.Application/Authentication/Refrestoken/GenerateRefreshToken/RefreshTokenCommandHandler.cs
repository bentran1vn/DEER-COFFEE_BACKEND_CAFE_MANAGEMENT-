using DeerCoffeeShop.Domain.Entities.Base;
using MediatR;
using System.Security.Cryptography;

namespace DeerCoffeeShop.Application.Authentication.Refrestoken.GenerateRefreshToken
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshToken>
    {
        public Task<RefreshToken> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var randome = new Byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randome);
            }
            string token = Convert.ToBase64String(randome);
            var refreshToken = new RefreshToken
            {
                Token = token,
                Expired = DateTime.Now.AddDays(7)
            };
            return Task.FromResult(refreshToken);
        }
    }
}
