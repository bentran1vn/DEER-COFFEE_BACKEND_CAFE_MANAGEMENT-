using DeerCoffeeShop.Application.Common.Interfaces;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DeerCoffeeShop.API.Services
{
    public class CurrentUserService(IHttpContextAccessor httpContextAccessor, IAuthorizationService authorizationService) : ICurrentUserService
    {
        private readonly ClaimsPrincipal? _claimsPrincipal = httpContextAccessor?.HttpContext?.User;

        public string? UserId => _claimsPrincipal?.FindFirst(JwtClaimTypes.Subject)?.Value;
        public string? UserName => _claimsPrincipal?.FindFirst(JwtClaimTypes.Name)?.Value;

        public async Task<bool> AuthorizeAsync(string policy)
        {
            if (_claimsPrincipal == null) return false;
            return (await authorizationService.AuthorizeAsync(_claimsPrincipal, policy)).Succeeded;
        }

        public async Task<bool> IsInRoleAsync(string role)
        {
            return await Task.FromResult(_claimsPrincipal?.IsInRole(role) ?? false);
        }
    }
}
