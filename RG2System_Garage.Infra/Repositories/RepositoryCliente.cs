using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente, int>, IRepositoyCliente
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryCliente(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
