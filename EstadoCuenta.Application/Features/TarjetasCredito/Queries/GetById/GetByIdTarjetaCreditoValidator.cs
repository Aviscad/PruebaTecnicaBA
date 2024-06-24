using FluentValidation;

namespace EstadoCuenta.Application.Features.TarjetasCredito.Queries.GetById
{
    public class GetByIdTarjetaCreditoValidator : AbstractValidator<GetByIdTarjetaCreditoQuery>
    {
        public GetByIdTarjetaCreditoValidator()
        {
            RuleFor(v => v.Id)
                .NotNull().WithMessage("El Id es requerido")
                .GreaterThan(0).WithMessage("El Id debe ser mayor a 0");
        }
    }
}
