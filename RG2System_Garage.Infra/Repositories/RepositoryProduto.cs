using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto, int>, IRepositoryProduto
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryProduto(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
