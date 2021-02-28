using System;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class ORPagamentoResponse
    {
        public Guid FormaPagamentoId { get; set; }
        public string DescricaoFormaPgt { get; set; }
        public Guid OrdemServicoId { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; } //apenas p/transferencia de grid
    }
}
