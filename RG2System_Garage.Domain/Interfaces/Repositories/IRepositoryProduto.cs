using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using System;

namespace RG2System_Garage.Domain.Interfaces.Repositories
{
    public interface IRepositoryProduto : IRepositoryBase<Produto, Guid>
    {
        bool InserirRegistroEstoqueProduto(EstoqueProduto estoqueProduto);
        Produto ObterComEstoqueProdutoAtual(Guid id);
    }
}
