using System;

namespace RG2System_Garage.Domain.Commands.OrdemServico
{
    public class ORPagamentoResquest
    {
        public Guid FormaPagamentoId { get; private set; }
        public Guid OrdemServicoId { get; private set; }
        public string Valor { get; private set; }
    }
}
