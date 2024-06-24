using EstadoCuenta.Application.Features.Compras.Command;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetAll;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetEstadoCuenta;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetTransacciones;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EstadoCuenta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarjetasCreditoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TarjetasCreditoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllTarjetasCreditoQuery()));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var query = new GetByIdTarjetaCreditoQuery { Id = id };
            var tarjeta = await _mediator.Send(query, cancellationToken);

            return Ok(tarjeta);
        }

        [HttpGet]
        [Route("{tarjetaCreditoId}/EstadoCuenta")]
        public async Task<IActionResult> GetEstadoCuenta(int tarjetaCreditoId, CancellationToken cancellationToken)
        {
            var query = new GetEstadoCuentaQuery { TarjetaCreditoId = tarjetaCreditoId };
            var tarjeta = await _mediator.Send(query, cancellationToken);

            return Ok(tarjeta);
        }

        [HttpGet]
        [Route("{tarjetaCreditoId}/Transacciones")]
        public async Task<IActionResult> GetTransacciones(int tarjetaCreditoId, CancellationToken cancellationToken)
        {
            var query = new GetTransaccionsQuery { TarjetaCreditoId = tarjetaCreditoId };
            var transacciones = await _mediator.Send(query, cancellationToken);

            return Ok(transacciones);
        }


    }
}
