using DeerCoffeeShop.Api.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Services;
using DeerCoffeeShop.Application.Authentication.Login;
using DeerCoffeeShop.Application.Employees;
using DeerCoffeeShop.Application.Employees.CreateEmployee;
using DeerCoffeeShop.Domain.Entities;
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

    [HttpGet("manager/employees")]
    public async Task<ActionResult<Employee>> GetAll([FromQuery] GetAllEmployeeQuery query, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(query, cancellationToken);
        return Ok(result);
    }

    [HttpPost("apply")]
    public async Task<ActionResult<string>> CreateEmployeeAplication([FromBody] CreateEmployeeCommand command, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(command, cancellationToken);
        return Ok(result);
    }

}
