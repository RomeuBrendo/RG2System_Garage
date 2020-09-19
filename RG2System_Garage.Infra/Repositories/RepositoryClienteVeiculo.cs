using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryClienteVeiculo : RepositoryBase<ClienteVeiculo, Guid>, IRepositoyClienteVeiculo 
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryClienteVeiculo(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
