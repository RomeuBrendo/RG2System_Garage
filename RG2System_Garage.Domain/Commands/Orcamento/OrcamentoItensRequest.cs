using System;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoItensRequest
    {
        public Guid OrcamentoId { get; set; }
        public Guid ProdutoServicoId { get; set; }
    }
}
