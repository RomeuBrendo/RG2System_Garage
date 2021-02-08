using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceOrdemServico : Notifiable, IServiceOrdemServico
    {
        private readonly IRepositoryFormaPagamento _repositoryFormaPagamento;
        private readonly IRepositoryOrdemServico _repositoryOrdemServico;
        private readonly IRepositoryORPagamento _repositoryORPagamento;

        public ServiceOrdemServico(IRepositoryFormaPagamento repositoryFormaPagamento, IRepositoryOrdemServico repositoryOrdemServico, IRepositoryORPagamento repositoryyORPagamento)
        {
            _repositoryFormaPagamento = repositoryFormaPagamento;
            _repositoryOrdemServico = repositoryOrdemServico;
            _repositoryORPagamento = repositoryyORPagamento;
        }

        public void AdicionarAlterar(OrdemServicoRequest request)
        {
            try
            {
                this.ClearNotifications();

                if (request == null)
                {
                    AddNotification("Request", "Request inválido");
                    return;
                }

                if ((request.Id.Value != Guid.Empty) && (request.Id.Value != null)) //Alteração
                {
                    var or = _repositoryOrdemServico.ObterPorId(request.Id.Value);

                    or.Alterar(request.DataFinalizacao.Value, request.Observacao, request.Status);

                    AddNotifications(or);

                    if (IsInvalid()) return;

                    _repositoryOrdemServico.Editar(or);

                    AtualizarPagamentos(request.FormaPagamentos);
                    return;

                }

                var novo = new OrdemServico(request.OrcamentoId, request.DataFinalizacao.Value, request.Status, request.Observacao, request.FormaPagamentos);

                AddNotifications(novo);

                if (IsInvalid()) return;

                _repositoryOrdemServico.Adicionar(novo);

            }
            catch (Exception ex)
            {
                AddNotification("AdicionarAlterar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AdicionarAlterar ") + ex);
                return;

            }
        }

        private List<ORPagamento> PopulaPagamentos(List<ORPagamentoResquest> formaPagamentos, Guid IdOrdemServico)
        {
            try
            {
                var novosPagamentos = new List<ORPagamento>();
                foreach (var item in formaPagamentos)
                {
                    var pagamento = new ORPagamento(item.FormaPagamentoId, IdOrdemServico, item.Valor.ToString());

                    if (pagamento.Notifications.Count < 1)
                        novosPagamentos.Add(pagamento);
                    else
                        AddNotifications(pagamento);
                }
                return novosPagamentos;
            }
            catch (Exception ex)
            {
                AddNotification("AtualizarPagamentos", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AtualizarPagamentos ") + ex);
                return null;
            }
        }
        private void AtualizarPagamentos(List<ORPagamentoResquest> formaPagamentos)
        {
            try
            {
                if ((formaPagamentos == null) || (formaPagamentos.Count < 1))
                    return;

                var pagamentos = _repositoryORPagamento.ListarPor(x => x.OrdemServico.Id == formaPagamentos[0].OrdemServicoId).ToList();

                if(pagamentos.Count > 0)
                    foreach (var item in formaPagamentos)
                    {
                        var pagamento = _repositoryORPagamento.ObterPor(x => x.FormaPagamentoId == item.FormaPagamentoId);

                        if (pagamento != null)
                        {
                            pagamento.AlterarValor(item.Valor.ToString());
                            
                            pagamentos.Where(x => x.Id == pagamento.Id).ToList().ForEach(x => x = pagamento);
                        }
                        else
                        {
                            var pagamentoNovo = new ORPagamento(item.FormaPagamentoId, item.OrdemServicoId, item.Valor.ToString());
                            AddNotifications(pagamentoNovo);

                            if (pagamentoNovo.Notifications.Count < 1)
                                pagamentos.Add(pagamentoNovo);
                        }
                    }

                _repositoryORPagamento.AdicionarLista(pagamentos);

            }
            catch (Exception ex)
            {
                AddNotification("AtualizarPagamentos", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AtualizarPagamentos ") + ex);
                return;

            }
        }
    }
}
