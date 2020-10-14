using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryConfiguracaoDadosEmpresa : RepositoryBase<ConfiguracaoDadosEmpresa, Guid>, IRepositoryConfiguracaoDadosEmpresa
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryConfiguracaoDadosEmpresa(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
