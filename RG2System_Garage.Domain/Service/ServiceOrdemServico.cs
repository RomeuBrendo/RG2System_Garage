using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Enum.Ordem_Servico;
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

        public List<OrdemServicoResponse> Listar()
        {
            try
            {
                return OrdemServicoResponse(_repositoryOrdemServico.Listar(x => x.Orcamento.Cliente).ToList());
            }
            catch (Exception ex)
            {
                AddNotification("Listar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Listar ") + ex);
                return null;
            }
        }

        private List<OrdemServicoResponse> OrdemServicoResponse(List<OrdemServico> listaOR)
        {
            return OrdemServicoResponse(listaOR, false);
        }
        private List<OrdemServicoResponse> OrdemServicoResponse(List<OrdemServico> listaOR, Boolean carregarPagamentos)
        {
            try
            {
                var orResponse = new List<OrdemServicoResponse>();

                foreach (var item in listaOR)
                {
                    var or = new OrdemServicoResponse();
                    or.Id = item.Id;
                    or.Numero = item.Numero;
                    or.OrcamentoNumero = (int)item.Orcamento.Numero;
                    or.ClienteNome = item.Orcamento.Cliente.Nome;
                    or.OrcamentoId = item.OrcamentoId;
                    or.Status = ReturnStatusDescricao(item.Status);
                    or.DataFinalizacao = item.DataFinalizacao;
                    or.Observacao = item.Observacao;
                    or.OrcamentoValor = item.Orcamento.ValorTotal.ToString("C2");
                    

                    if (carregarPagamentos)
                        or.Pagamentos = PagamentosResponse(item.FormaPagamentos);

                    orResponse.Add(or);
                }

                return orResponse.OrderBy(x => x.Numero).ToList();
            }
            catch (Exception ex)
            {
                AddNotification("PopularOr", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("PopularOr ") + ex);
                return null;
            }
        }

        private string ReturnStatusDescricao(EnumStatus enumStatus)
        {
            switch (enumStatus)
            {
                case EnumStatus.Aguardando:
                    return "Aguardando";

                case EnumStatus.EmServico:
                    return "Em serviço";
                
                case EnumStatus.Finalizado:
                    return "Finalizado";
            }

            return "";
        }

        private List<ORPagamentoResponse> PagamentosResponse(List<ORPagamento> listaPagamento)
        {
            try
            {
                var pagamentosResponse = new List<ORPagamentoResponse>();

                foreach (var item in listaPagamento.ToList())
                {
                    var pagamento = new ORPagamentoResponse();
                    pagamento.FormaPagamentoId = item.FormaPagamentoId;
                    pagamento.OrdemServicoId = item.OrdemServicoId;
                    pagamento.Valor = item.Valor.ToString("C2");
                    pagamento.Descricao = _repositoryFormaPagamento.ReturnDescricaoPagamento_ById(item.FormaPagamentoId);

                    pagamentosResponse.Add(pagamento);
                }
                return pagamentosResponse;
            }
            catch (Exception ex)
            {
                AddNotification("PopularPagamentos", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("PopularPagamentos ") + ex);
                return null;
            }
        }

        //private List<ORPagamento> PopulaPagamentos(List<ORPagamentoResquest> formaPagamentos, Guid IdOrdemServico)
        //{
        //    try
        //    {
        //        var novosPagamentos = new List<ORPagamento>();
        //        foreach (var item in formaPagamentos)
        //        {
        //            var pagamento = new ORPagamento(item.FormaPagamentoId, IdOrdemServico, item.Valor.ToString());

        //            if (pagamento.Notifications.Count < 1)
        //                novosPagamentos.Add(pagamento);
        //            else
        //                AddNotifications(pagamento);
        //        }
        //        return novosPagamentos;
        //    }
        //    catch (Exception ex)
        //    {
        //        AddNotification("AtualizarPagamentos", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AtualizarPagamentos ") + ex);
        //        return null;
        //    }
        //}
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

        public OrdemServicoResponse Obter_ByNumero(Int64 numero)
        {
            try
            {
                return OrdemServicoResponse(_repositoryOrdemServico.ListarPor(x => x.Numero == numero, x => x.FormaPagamentos).ToList(), true).FirstOrDefault();
            }
            catch 
            {
                AddNotification("Obter_ByNumero", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Obter_ByNumero"));
                return null;
            }
        }
    }
}
