namespace EstadoCuenta.Domain.Exceptions
{
    public class PagoMinimoException : Exception
    {
        public PagoMinimoException()
        {
        }

        public PagoMinimoException(string? message) : base(message)
        {
        }

        public PagoMinimoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}