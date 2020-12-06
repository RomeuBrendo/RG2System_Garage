using RG2System_Garage.Domain.Enum;
using System;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoItensRequest
    {
        public Guid OrcamentoId { get; set; }
        public Guid ProdutoServicoId { get; set; }
        public int Quantidade { get; set; }
        public EnumTipo Tipo { get; set; }
        public Decimal PrecoVenda { get; set; }
    }
}
