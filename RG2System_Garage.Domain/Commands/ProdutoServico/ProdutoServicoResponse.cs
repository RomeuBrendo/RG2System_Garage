using RG2System_Garage.Domain.Enum;
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
        public string TipoDescricao { get; set; }
        public EnumTipo Tipo { get; set; }
        public EnumSituacao Situacao { get; set; }
        public string Observacao { get; set; }

        public static explicit operator ProdutoResponse(Entities.ProdutoServico v)
        {
            return new ProdutoResponse()
            {
                Id = v.Id,
                Tipo = v.Tipo,
                Descricao = v.Descricao,
                Observacao = v.Observacao,
                Situacao = v.Situacao,
                Estoque = v.FichaMovimentacao.OrderByDescending(x => x.DataLancamento).Select(x => x.EstoqueAtual).FirstOrDefault(),
                PrecoVenda = v.FichaMovimentacao.OrderByDescending(x => x.DataLancamento).Select(x => x.PrecoVenda).FirstOrDefault(),
                PrecoCusto = v.FichaMovimentacao.OrderByDescending(x => x.DataLancamento).Select(x => x.PrecoCusto).FirstOrDefault()
            };
        }
    }
}
