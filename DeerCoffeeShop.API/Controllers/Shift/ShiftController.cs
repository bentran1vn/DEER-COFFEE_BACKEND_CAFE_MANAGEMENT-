using DeerCoffeeShop.Api.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Controllers.ResponseTypes;
using DeerCoffeeShop.Application.Common.Security;
using DeerCoffeeShop.Application.Shift;
using DeerCoffeeShop.Application.Shift.Create;
using DeerCoffeeShop.Application.Shift.Delete;
using DeerCoffeeShop.Application.Shift.GetAll;
using DeerCoffeeShop.Application.Shift.Update;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace DeerCoffeeShop.API.Controllers.Shift
{
    [ApiController]
    [Authorize]
    public class ShiftController(ISender sender) : BaseController(sender)
    {
        private readonly ISender _mediator = sender;

        [HttpGet]
        [ProducesResponseType(typeof(List<ShiftDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<List<ShiftDto>>> GetAllShift(CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(new GetAllShiftQuery(), cancellationToken);
            return Ok(new JsonResponse<List<ShiftDto>>(result));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> CreateNewShift([FromBody] CreateShiftCommand command, CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> UpdateShift([FromBody] UpdateShiftCommand command, CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpDelete("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> RemoveShift([FromRoute] int id, CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(new DeleteShiftCommand(id), cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }
    }
}
