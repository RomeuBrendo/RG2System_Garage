using RG2System_Garage.Domain.Entities;
using System;

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
                Estoque = v.EstoqueProduto.EstoqueAtual,
                PrecoCusto = v.EstoqueProduto.PrecoCusto,
                PrecoVenda = v.EstoqueProduto.PrecoVenda
            };
        }
    }
}
