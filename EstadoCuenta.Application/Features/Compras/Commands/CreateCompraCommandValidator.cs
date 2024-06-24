using EstadoCuenta.Application.Features.Compras.Command;
using FluentValidation;

namespace EstadoCuenta.Application.Features.Compras.Commands
{
    public class CreateCompraCommandValidator : AbstractValidator<CreateCompraCommand>
    {
        public CreateCompraCommandValidator()
        {
            RuleFor(v => v.TarjetaCreditoId)
                .NotEmpty().WithMessage("El campo TarjetaCreditoId es requerido");
            RuleFor(v => v.Descripcion)
                .NotEmpty().WithMessage("Debe proporcionar una descripción");
            RuleFor(v => v.Fecha)
                .NotEmpty().WithMessage("Debe proporcionar una fecha")
                .Must(ValidDate).WithMessage("La fecha es Inválida");
            RuleFor(v => v.Monto)
                .NotEmpty().WithMessage("El monto es requerido")
                .GreaterThan(0).WithMessage("El monto debe ser mayor a 0");
        }

        private bool ValidDate(DateTime date)
        {
            return date > DateTime.MinValue && date < DateTime.MaxValue;
        }
    }
}
