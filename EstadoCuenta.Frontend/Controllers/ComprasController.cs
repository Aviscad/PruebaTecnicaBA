using EstadoCuenta.Application.Features.Compras.Command;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById;
using FrontendRazor.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FrontendRazor.Controllers
{
    public class ComprasController : Controller
    {
        private readonly IMediator _mediator;

        public ComprasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> AgregarCompra(int tarjetaId)
        {

            var query = new GetByIdTarjetaCreditoQuery { Id = tarjetaId };
            var tarjeta = await _mediator.Send(query);

            var model = new ComprasModel();
            model.TarjetaCreditoId = tarjetaId;

            ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
            ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
            ViewData["TarjetaId"] = tarjetaId;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GuardarCompra(ComprasModel model, [FromForm] int tarjetaId)
        {
            if (!ModelState.IsValid)
            {
                var query = new GetByIdTarjetaCreditoQuery { Id = tarjetaId };
                var tarjeta = await _mediator.Send(query);

                ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
                ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
                ViewData["TarjetaId"] = tarjetaId;

                return View("AgregarCompra", model);
            }

            var command = new CreateCompraCommand
            {
                TarjetaCreditoId = tarjetaId,
                Fecha = model.Fecha,
                Descripcion = model.Descripcion,
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
                ViewData["TarjetaId"] = tarjetaId;

                return View("AgregarCompra", model);
            }
        }
    }
}
