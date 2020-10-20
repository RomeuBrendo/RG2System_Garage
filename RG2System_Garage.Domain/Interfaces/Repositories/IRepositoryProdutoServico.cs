using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using System;

namespace RG2System_Garage.Domain.Interfaces.Repositories
{
    public interface IRepositoryProdutoServico : IRepositoryBase<ProdutoServico, Guid>
    {
        bool InserirRegistroMovimentacao(Movimentacao estoqueProduto);
        ProdutoServico ObterComEstoqueProdutoAtual(Guid id);
    }
}
