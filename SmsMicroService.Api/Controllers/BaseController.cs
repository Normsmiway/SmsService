using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;

namespace SmsMicroService.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;
        protected readonly IMediator _mediator;

        protected BaseController(IMediator mediator, ILogger<BaseController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}