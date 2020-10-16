using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryOrcamento : RepositoryBase<Orcamento, Guid>, IRepositoryOrcamento
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryOrcamento(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
