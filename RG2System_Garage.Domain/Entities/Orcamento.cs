using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Entities
{
    public class Orcamento : EntityBase
    {
        protected Orcamento()
        {

        }
        public Orcamento(Cliente cliente, string formaPagamento, double valorTotal, double valorDesconto, double valorAcrescimo, string observacao, bool existeOrdemServico, DateTime dataCriacao, List<OrcamentoItem> itens)
        {
            Cliente = cliente;
            FormaPagamento = formaPagamento;
            ValorTotal = valorTotal;
            ValorDesconto = valorDesconto;
            ValorAcrescimo = valorAcrescimo;
            Observacao = observacao;
            ExisteOrdemServico = existeOrdemServico;
            DataCriacao = dataCriacao;
            Itens = itens;

            if (Itens == null)
            {
                AddNotification("Itens", MSG.X0_INVALIDO.ToFormat("Itens"));
            }

            new AddNotifications<Orcamento>(this)
                .IfNullOrEmpty(x => x.FormaPagamento, MSG.X0_INVALIDA.ToFormat("Forma Pagamento"))
                .IfNotDate(x => x.DataCriacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data Criação"));

            if (ValorTotal == 0)
            {
                AddNotification("ValorTotal", MSG.X0_INVALIDO.ToFormat("Valor Total"));
            }
                
        }

        public Cliente Cliente { get; private set; }
        public string FormaPagamento { get; private set; } // Futuramente terá um cadastro exclusivo para forma de pagamento.
        public double ValorTotal { get; private set; }
        public double ValorDesconto { get; private set; }
        public double ValorAcrescimo { get; private set; }
        public string Observacao { get; private set; }
        public bool ExisteOrdemServico { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public List<OrcamentoItem> Itens { get; private set; }
    }
}
