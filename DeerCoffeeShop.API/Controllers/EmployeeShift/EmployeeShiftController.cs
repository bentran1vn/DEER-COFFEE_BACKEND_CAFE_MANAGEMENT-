using DeerCoffeeShop.Api.Controllers.ResponseTypes;
using DeerCoffeeShop.API.Controllers.ResponseTypes;
using DeerCoffeeShop.Application.Common.Pagination;
using DeerCoffeeShop.Application.EmployeeShift;
using DeerCoffeeShop.Application.EmployeeShift.Delete;
using DeerCoffeeShop.Application.EmployeeShift.GetAll;
using DeerCoffeeShop.Application.EmployeeShift.GetByEmployeeId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DeerCoffeeShop.API.Controllers.EmployeeShift
{
    public class EmployeeShiftController(ISender sender) : BaseController(sender)
    {
        private readonly ISender _mediator = sender;

        [HttpGet("{page_no}/{page_size}")]
        [ProducesResponseType(typeof(PagedResult<EmployeeShiftDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<JsonResponse<PagedResult<EmployeeShiftDto>>>> GetAll
            ([FromRoute] int page_no, [FromRoute] int page_size, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllEmployeeShiftQuery(page_no, page_size), cancellationToken);
            return Ok(new JsonResponse<PagedResult<EmployeeShiftDto>>(result));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<JsonResponse<string>>> DeleteEmployeeShift([FromRoute] string employee_id, [FromRoute] string restaurant_id
            , [FromRoute] int shift_id,CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new DeleteEmployeeShiftCommand(employee_id, restaurant_id, shift_id), cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpGet("{page_no}/{page_size}/{employee_id}")]
        [ProducesResponseType(typeof(PagedResult<EmployeeShiftDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<JsonResponse<PagedResult<EmployeeShiftDto>>>> GetAll
            ([FromRoute] int page_no, [FromRoute] int page_size, [FromRoute] string employee_id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetEmployeeShiftByEmployeeIdQuery(employee_id, page_no, page_size), cancellationToken);
            return Ok(new JsonResponse<PagedResult<EmployeeShiftDto>>(result));
        }
    }
}
