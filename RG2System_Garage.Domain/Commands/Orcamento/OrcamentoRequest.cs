using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class OrcamentoRequest
    {
        public Guid? Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid VeiculoId { get; set; }
        public string FormaPagamento { get;  set; } //Será implementado em seguida, tendo uma tabela separada
        public string ValorTotal { get;  set; }
        public string ValorDesconto { get; set; }
        public string ValorAcrescimo { get; set; }
        public string Observacao { get; set; } //Será implementado junto com a forma de pagamento.
        public bool ExisteOrdemServico { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<OrcamentoItensRequest> Itens { get; set; }
    }
}
