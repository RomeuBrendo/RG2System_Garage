using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.OrdemServico;
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
        public OrdemServico(Guid orcamentoId, DateTime dataFinalizacao, EnumStatus status, string observacao, List<ORPagamentoResquest> formaPagamentos)
        {
            
            DataFinalizacao = dataFinalizacao;

            Status = status;
            Observacao = observacao;
            PopulaPagamentos(formaPagamentos);

            this.ClearNotifications();
            new AddNotifications<OrdemServico>(this)
                //.IfNotDate(x => x.DataFinalizacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data"))
                .IfEnumInvalid(x => x.Status, MSG.X0_INVALIDO.ToFormat("Status"));

            OrcamentoId = orcamentoId;
            
        }

        private void PopulaPagamentos(List<ORPagamentoResquest> formaPagamentos)
        {
            try
            {
                if (formaPagamentos == null)
                {
                    AddNotification("FormaPagamento", MSG.X0_E_OBRIGATORIA.ToFormat("Forma de pagemto"));
                    return;
                }
                var novosPagamentos = new List<ORPagamento>();
                foreach (var item in formaPagamentos)
                {
                    if (item.Valor <= 0)
                        continue;

                    var pagamento = new ORPagamento(item.FormaPagamentoId, Id, item.Valor.ToString());

                    if (pagamento.Notifications.Count < 1)
                        novosPagamentos.Add(pagamento);
                    else
                        AddNotifications(pagamento);
                }

                FormaPagamentos = novosPagamentos;
                
            }
            catch (Exception ex)
            {
                AddNotification("AtualizarPagamentos", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("PopulaPagamentos ") + ex);    
            }
        }
        public void Alterar(DateTime dataFinalizacao, string obs, EnumStatus status)
        {
            if (dataFinalizacao != null)
                DataFinalizacao = dataFinalizacao;
            
            Status = status;
            Observacao = obs;

            this.ClearNotifications();
            new AddNotifications<OrdemServico>(this)
                .IfNotDate(x => x.DataFinalizacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data"))
                .IfEnumInvalid(x => x.Status, MSG.X0_INVALIDO.ToFormat("Status"));
        }

        public void AlterarStatus(EnumStatus status)
        {
            Status = status;
        }

        public Int32 Numero { get; private set; }
        public Orcamento Orcamento { get; private set; }
        public List<ORPagamento> FormaPagamentos { get; private set; }
        public DateTime ? DataFinalizacao { get; private set; }
        public EnumStatus Status { get; private set; }
        public string Observacao { get; private set; }

        public Guid OrcamentoId { get; set; }
    }

}
