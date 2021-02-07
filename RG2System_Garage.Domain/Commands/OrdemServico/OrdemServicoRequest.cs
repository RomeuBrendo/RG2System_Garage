using RG2System_Garage.Domain.Enum.Ordem_Servico;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class OrdemServicoRequest
    {
        public Guid ? Id { get; set; }
        public Guid OrcamentoId { get; set; }
        public List<ORPagamentoResquest> FormaPagamentos { get; set; }
        public DateTime ? DataFinalizacao { get; set; }
        public EnumStatus Status { get; set; }
        public string Observacao { get; set; }
    }


}
