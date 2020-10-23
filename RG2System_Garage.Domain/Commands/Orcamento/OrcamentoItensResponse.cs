using RG2System_Garage.Domain.Commands.Produto;
using System;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoItensResponse
    {
        public Guid Id { get; set; }
        public ProdutoServicoResponse ProdutoServico { get; set; }
    }
}
