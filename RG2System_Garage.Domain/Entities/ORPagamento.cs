using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class ORPagamento : EntityBase 
    {
        protected ORPagamento()
        {

        }
        public ORPagamento(ORPagamento formaPagamentoId, OrdemServico ordemServico, string valor)
        {
            decimal number = 0;
            if (decimal.TryParse(valor, out number))
                Valor = number;
            else
                AddNotification("Valor", MSG.X0_INVALIDO.ToFormat("Valor produto/serviço"));

            FormaPagamento = formaPagamentoId;
            OrdemServico = ordemServico;
        }

        public void AlterarValor(string valor)
        {
            this.ClearNotifications();

            decimal number = 0;
            if (decimal.TryParse(valor, out number))
                Valor = number;
            else
                AddNotification("Valor", MSG.X0_INVALIDO.ToFormat("Valor produto/serviço"));
        }
        public ORPagamento FormaPagamento { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public decimal Valor { get; private set; }
    }
}
