using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmsMicroService.Application.UseCases.SendSms;

namespace SmsMicroService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmsController : BaseController
    {
        public SmsController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IActionResult> SendSms([FromBody] SmsRequest request)
        {
            var command = new SendSmsCommand(request.Body, request.PhoneNumber);

            return Ok(await _mediator.Send(command));
        }
    }
}