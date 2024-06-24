namespace EstadoCuenta.Application.Services
{
    public class NumeroAutorizacionService
    {
        private static Random random = new Random();

        public static int Create()
        {
            int minimo = 1; 
            int maximo = 1000000000; 

            int numeroAutorizacion = random.Next(minimo, maximo + 1);

            return numeroAutorizacion;
        }
    }
}
