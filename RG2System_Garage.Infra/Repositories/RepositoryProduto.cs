using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        public Produto ObterComEstoqueProdutoAtual(Guid id)
        {
            try
            {

                var produto = _context.Produtos.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();

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
