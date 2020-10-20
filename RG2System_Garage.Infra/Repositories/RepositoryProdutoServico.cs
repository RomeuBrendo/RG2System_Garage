using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;
using System.Data.Entity;
using System.Linq;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryProdutoServico : RepositoryBase<ProdutoServico, Guid>, IRepositoryProdutoServico
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryProdutoServico(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }

        public bool InserirRegistroMovimentacao(Movimentacao estoqueProduto)
        {
            try
            {
                _context.Movimentacao.Add(estoqueProduto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ProdutoServico ObterComEstoqueProdutoAtual(Guid id)
        {
            try
            {

                var produto = _context.ProdutosServicos.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();

                // Apenas para preencher o campo EstoqueProduto que não consta a coluna no banco, apenas no código
                produto.AlterarPropriedade(produto);

                return produto;
            }
            catch
            {

                return null;
            }

        }
    }
}
