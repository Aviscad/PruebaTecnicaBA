using FluentValidation;

namespace EstadoCuenta.Application.Features.Pagos.Commands
{
    public class CreatePagoCommandValidator : AbstractValidator<CreatePagoCommand>
    {
        public CreatePagoCommandValidator()
        {
            RuleFor(v => v.TarjetaCreditoId)
                .NotEmpty().WithMessage("El campo TarjetaCreditoId es requerido");
            RuleFor(v => v.Monto)
                .NotEmpty().WithMessage("Debe proporcionar un monto")
                .GreaterThan(0).WithMessage("El monto debe ser mayor a 0");
            RuleFor(v => v.Fecha)
                .NotEmpty().WithMessage("Debe proporcionar una fecha")
                .Must(ValidDate).WithMessage("La fecha es Inválida");
        }
        private bool ValidDate(DateTime date)
        {
            return date > DateTime.MinValue && date < DateTime.MaxValue;
        }
    }
}
