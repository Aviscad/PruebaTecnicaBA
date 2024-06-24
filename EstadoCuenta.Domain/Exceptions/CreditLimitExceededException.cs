namespace EstadoCuenta.Domain.Exceptions
{
    public class CreditLimitExceededException : Exception
    {

        public CreditLimitExceededException()
        {
        }

        public CreditLimitExceededException(string message)
            : base(message)
        {
        }

        public CreditLimitExceededException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}