using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoRequest
    {
        public Guid? Id { get; set; }
        public Guid ClienteId { get; set; }
        public string FormaPagamento { get;  set; }
        public double ValorTotal { get;  set; }
        public double ValorDesconto { get; set; }
        public double ValorAcrescimo { get; set; }
        public string Observacao { get; set; }
        public bool ExisteOrdemServico { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<OrcamentoItensRequest> Itens { get; set; }
    }
}
