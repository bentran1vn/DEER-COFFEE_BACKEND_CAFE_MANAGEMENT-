using DeerCoffeeShop.Api.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Services;
using DeerCoffeeShop.Application.Authentication.Login;
using DeerCoffeeShop.Application.Test;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeerCoffeeShop.API.Controllers;


public class EmployeeController(ISender sender, JwtService _jwtService) : BaseController(sender)
{

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginQuery loginQuery, CancellationToken cancellationToken = default)
    {
        var loginDTO = await _sender.Send(new LoginQuery(loginQuery.EmployeeID, loginQuery.Password), cancellationToken);
        var token = _jwtService.CreateToken(loginDTO.Id, loginDTO.RoleName, loginDTO.RefreshToken);
        return Ok(token);
    }
    [Authorize]
    [HttpPost("checkin")]
    public async Task<IActionResult> CheckIn(TestCheckIn testCheckIn, CancellationToken cancellationToken = default)
    {
        var result = await _sender.Send(new TestCheckIn(testCheckIn.EmployeeID,testCheckIn.Actual_CheckIn), cancellationToken);

        return Ok(new JsonResponse<string>(result));
    }
}
