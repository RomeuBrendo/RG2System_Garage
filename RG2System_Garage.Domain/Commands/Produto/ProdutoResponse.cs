using System;
using System.Linq;

namespace RG2System_Garage.Domain.Commands.Produto
{
    public class ProdutoResponse
    {
        public Guid Id { get; set; }
        public string Descricao { get;  set; }
        public int Estoque { get;  set; }
        public float PrecoVenda { get; set; }
        public float PrecoCusto { get; set; }

        public static explicit operator ProdutoResponse(Entities.Produto v)
        {
            return new ProdutoResponse()
            {
                Id = v.Id,
                Descricao = v.Descricao,
                Estoque = v.FichaEstoqueProduto.OrderByDescending(x => x.DataLancamento).Select(x => x.EstoqueAtual).FirstOrDefault(),
                PrecoVenda = v.FichaEstoqueProduto.OrderByDescending(x => x.PrecoVenda).Select(x => x.PrecoVenda).FirstOrDefault(),
                PrecoCusto = v.FichaEstoqueProduto.OrderByDescending(x => x.PrecoCusto).Select(x => x.PrecoCusto).FirstOrDefault(),
            };
        }
    }
}
