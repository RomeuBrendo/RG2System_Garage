using RG2System_Garage.Domain.Commands.Cliente;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoResponse
    {
        public Guid Id { get; set; }
        public Int64 Numero { get; set; }
        public ClienteResponse Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorTotal { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorAcrescimo { get; set; }
        public string Observacao { get; set; }
        public bool ExisteOrdemServico { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<OrcamentoItensResponse> Itens { get; set; }

    }
}
