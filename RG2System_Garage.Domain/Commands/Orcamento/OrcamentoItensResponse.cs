using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Enum;
using System;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoItensResponse
    {
        public Guid OrcamentoId { get; set; }
        public ProdutoServicoResponse ProdutoServico { get; set; }
        public int Quantidade { get; set; }
        //public EnumTipo Tipo { get; set; }
        public Decimal PrecoVenda { get; set; }
    }
}
