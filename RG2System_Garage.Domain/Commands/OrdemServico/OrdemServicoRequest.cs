using RG2System_Garage.Domain.Enum.Ordem_Servico;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class OrdemServicoRequest
    {
        public Guid ? Id { get; set; }
        public Guid OrcamentoId { get; private set; }
        public List<ORPagamentoResquest> FormaPagamentos { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
        public EnumStatus Status { get; private set; }
        public string Observacao { get; private set; }
    }


}
