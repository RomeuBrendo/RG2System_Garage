using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryOrdemServico : RepositoryBase<OrdemServico, Guid>, IRepositoryOrdemServico
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryOrdemServico(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
