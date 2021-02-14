using RG2System_Garage.Domain.Enum.Ordem_Servico;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class OrdemServicoResponse
    {
        public int Numero { get; set; }
        public int OrcamentoNumero { get; set; }
        public string ClienteNome { get; set; }
        public Guid? Id { get; set; }
        public Guid OrcamentoId { get; set; }
        public List<ORPagamentoResponse> Pagamentos { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
        public string OrcamentoValor { get; set; }
    }
}
