using AutoMapper;
using EstadoCuenta.Domain.Entities;
using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Data;

namespace EstadoCuenta.Infrastructure.Repositories
{
    public class TransaccionRepository : GenericRepository<Transaccion>, ITransaccionRespository
    {
        public TransaccionRepository(ApplicationDbContext context, IMapper _mapper) 
            : base(context, _mapper)
        {
        }
    }
}
