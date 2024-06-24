using EstadoCuenta.Application.Features.Pagos.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EstadoCuenta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PagoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePagoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
