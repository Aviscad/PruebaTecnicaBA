using EstadoCuenta.Application.Features.Pagos.Commands;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById;
using FrontendRazor.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FrontendRazor.Controllers
{
    public class PagosController : Controller
    {
        private readonly IMediator _mediator;

        public PagosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AgregarPago(int tarjetaId)
        {
            var query = new GetByIdTarjetaCreditoQuery { Id = tarjetaId };
            var tarjeta = await _mediator.Send(query);

            var model = new PagosModel();

            ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
            ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
            ViewData["TarjetaId"] = tarjetaId;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GuardarPago(PagosModel model, [FromForm] int tarjetaId)
        {
            if (!ModelState.IsValid)
            {
                var query = new GetByIdTarjetaCreditoQuery { Id = tarjetaId };
                var tarjeta = await _mediator.Send(query);

                ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
                ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
                ViewData["TarjetaId"] = tarjetaId;

                return View("AgregarPago", model);
            }

            var command = new CreatePagoCommand
            {
                TarjetaCreditoId = tarjetaId,
                Fecha = model.Fecha,
                Monto = model.Monto
            };

            try
            {
                var result = await _mediator.Send(command);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                var query = new GetByIdTarjetaCreditoQuery { Id = tarjetaId };
                var tarjeta = await _mediator.Send(query);

                ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
                ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
                ViewData["Error"] = ex.Message;
                ViewData["TarjetaId"] = tarjetaId;

                return View("AgregarPago", model);
            }
        }
    }
}
