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
            double number = 0;
            if (Double.TryParse(valor, out number))
                Valor = number;
            else
                AddNotification("Valor", MSG.X0_INVALIDO.ToFormat("Valor produto/serviço"));

            FormaPagamento = formaPagamentoId;
            OrdemServico = ordemServico;
        }

        public void AlterarValor(string valor)
        {
            this.ClearNotifications();

            double number = 0;
            if (Double.TryParse(valor, out number))
                Valor = number;
            else
                AddNotification("Valor", MSG.X0_INVALIDO.ToFormat("Valor produto/serviço"));
        }
        public ORPagamento FormaPagamento { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public double Valor { get; private set; }
    }
}
