using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Globalization;

namespace RG2System_Garage.Domain.Entities
{
    public class ORPagamento : EntityBase 
    {
        protected ORPagamento()
        {

        }
        public ORPagamento(Guid formaPagamentoId, Guid ordemServicoId, string valor)
        {
            this.ClearNotifications();

            decimal number = 0;
            if (decimal.TryParse(valor, out number))
                Valor = number;
            else
                AddNotification("Valor", MSG.X0_INVALIDO.ToFormat("Valor produto/serviço"));

            FormaPagamentoId = formaPagamentoId;
            OrdemServicoId = ordemServicoId;
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
        public Guid FormaPagamentoId { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public Guid OrdemServicoId { get; private set; }
        public decimal Valor { get; private set; }
    }
}
