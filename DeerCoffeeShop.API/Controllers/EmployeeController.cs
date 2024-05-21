using DeerCoffeeShop.API.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Services;
using DeerCoffeeShop.Application.Authentication.LoginQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeerCoffeeShop.API.Controllers;


public class EmployeeController(ISender sender, JwtService _jwtService) : BaseController(sender)
{

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginQuery loginQuery, CancellationToken cancellationToken = default)
    {
        var loginDTO = await _sender.Send(new LoginQuery(loginQuery.EmployeeID, loginQuery.Password), cancellationToken);
        var token = _jwtService.CreateToken(loginDTO.Id, loginDTO.RoleId,loginDTO.RefreshToken);
        return Ok(token);
    }
}
