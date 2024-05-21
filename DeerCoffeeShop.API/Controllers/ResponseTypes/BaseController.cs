using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeerCoffeeShop.API.Controllers.ResponseTypes
{
    [Route("api/v{apiVersion:apiVersion}/[controller]")]
    [ApiController]
    public class BaseController(ISender sender) : ControllerBase
    {
        protected readonly ISender _sender = sender;
    }
}
