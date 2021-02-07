using System;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class ORPagamentoResquest
    {
        public Guid FormaPagamentoId { get; set; }
        public Guid OrdemServicoId { get; set; }
        public decimal Valor { get; set; }

        public string Descricao { get; set; } //apenas p/transferencia de grid
    }
}
