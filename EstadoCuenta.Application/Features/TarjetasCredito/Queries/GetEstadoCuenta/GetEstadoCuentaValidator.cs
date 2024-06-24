using FluentValidation;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetEstadoCuenta
{
    public class GetEstadoCuentaValidator : AbstractValidator<GetEstadoCuentaQuery>
    {
        public GetEstadoCuentaValidator()
        {
            RuleFor(v => v.TarjetaCreditoId)
               .NotNull().WithMessage("TarjetaCreditoId es requerido")
               .GreaterThan(0).WithMessage("TarjetaCreditoId debe ser mayor a 0");
        }
    }
}
