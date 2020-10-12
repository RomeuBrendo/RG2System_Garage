using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto, Guid>, IRepositoryProduto
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryProduto(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }

        public bool InserirRegistroEstoqueProduto(EstoqueProduto estoqueProduto)
        {
            try
            {
                _context.EstoqueProdutos.Add(estoqueProduto);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
