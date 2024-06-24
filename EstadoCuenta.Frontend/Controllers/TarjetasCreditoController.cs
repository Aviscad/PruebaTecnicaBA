using Microsoft.AspNetCore.Mvc;
using MediatR;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetEstadoCuenta;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetTransacciones;
using EstadoCuenta.Domain.DTOs;
using FrontendRazor.Models;
using EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById;

namespace EstadoCuenta.Web.Controllers
{
    public class TarjetasCreditoController : Controller
    {
        private readonly IMediator _mediator;

        public TarjetasCreditoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> EstadoCuenta(int tarjetaId)
        {
            try
            {


                var tarjeta = await _mediator.Send(new GetByIdTarjetaCreditoQuery { Id = tarjetaId });

                ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
                ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
                ViewData["TarjetaId"] = tarjetaId;

                var query = new GetEstadoCuentaQuery { TarjetaCreditoId = tarjetaId };
                var estadoCuenta = await _mediator.Send(query);

                if (estadoCuenta == null)
                {
                    return NotFound();
                }

                return View(estadoCuenta);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Transacciones(int tarjetaId)
        {
            try
            {
                var tarjeta = await _mediator.Send(new GetByIdTarjetaCreditoQuery { Id = tarjetaId });

                ViewData["NombreCliente"] = $"{tarjeta.Nombre} {tarjeta.Apellidos}";
                ViewData["NumeroTarjeta"] = tarjeta.NumeroTarjeta;
                ViewData["TarjetaId"] = tarjetaId;

                var query = new GetTransaccionsQuery { TarjetaCreditoId = tarjetaId };
                var transacciones = await _mediator.Send(query);

                var transaccionesModel = transacciones.Select(dto => new TransaccionesModel
                {
                    NumeroAutorizacion = dto.NumeroAutorizacion,
                    Fecha = new DateTime(dto.Fecha.Year, dto.Fecha.Month, dto.Fecha.Day), // Si es necesario convertir DateOnly a DateTime
                    Descripcion = dto.Descripcion,
                    Cargo = dto.Cargo,
                    Abono = dto.Abono
                }).ToList();

                if (transacciones == null)
                {
                    return NotFound();
                }

                return View(transaccionesModel);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
