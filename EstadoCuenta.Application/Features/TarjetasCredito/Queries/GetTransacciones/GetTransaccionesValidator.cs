using FluentValidation;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetTransacciones
{
    public class GetTransaccionesValidator : AbstractValidator<GetTransaccionsQuery>
    {
        public GetTransaccionesValidator()
        {
            RuleFor(v => v.TarjetaCreditoId)
               .NotNull().WithMessage("TarjetaCreditoId es requerido")
               .GreaterThan(0).WithMessage("TarjetaCreditoId debe ser mayor a 0");
        }
    }
}
