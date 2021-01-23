using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Enum.Ordem_Servico;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Entities
{
    public class OrdemServico : EntityBase
    {
        protected OrdemServico()
        {

        }
        public OrdemServico(Orcamento orcamento, List<ORPagamento> formaPagamentos, DateTime dataFinalizacao, EnumStatus status, string observacao)
        {
            DataFinalizacao = dataFinalizacao;
            Status = status;
            Observacao = observacao;

            this.ClearNotifications();
            new AddNotifications<OrdemServico>(this)
                .IfNotDate(x => x.DataFinalizacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data"))
                .IfEnumInvalid(x => x.Status, MSG.X0_INVALIDO.ToFormat("Status"));

            Orcamento = orcamento;
            
            if (formaPagamentos != null)
                FormaPagamentos = formaPagamentos;
            
        }

        public void AlterarStatus(EnumStatus status)
        {
            Status = status;
        }

        public Orcamento Orcamento { get; private set; }
        public List<ORPagamento> FormaPagamentos { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
        public EnumStatus Status { get; private set; }
        public string Observacao { get; private set; }
    }

}
