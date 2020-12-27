using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceOrcamento : Notifiable, IServiceOrcamento
    {
        private readonly IRepositoryOrcamento _repositoryOrcamento;
        private readonly IRepositoyCliente _repositoyCliente;
        private readonly IRepositoryProdutoServico _repositoryProdutoServico;

        public ServiceOrcamento(IRepositoryOrcamento repositoryOrcamento, IRepositoyCliente repositoyCliente, IRepositoryProdutoServico repositoryProdutoServico)
        {
            _repositoryOrcamento = repositoryOrcamento;
            _repositoyCliente = repositoyCliente;
            _repositoryProdutoServico = repositoryProdutoServico;
        }

        public void AdicionarAlterar(OrcamentoRequest request)
        {
            try
            {
                this.ClearNotifications();
                if (request == null)
                {
                    AddNotification("Request", MSG.X0_INVALIDO.ToFormat("Inválido"));
                    return;
                }

                if ((request.Id != null) && (request.Id != Guid.Empty)) //Alteração
                {
                    var orcamento = _repositoryOrcamento.ObterPorId(request.Id.Value);

                    orcamento.Alterar(request);

                    AddNotifications(orcamento);

                    if (IsInvalid()) return;

                    _repositoryOrcamento.Editar(orcamento);
                    return;
                }
                
                var orcamentoNovo = new Orcamento(request, _repositoyCliente.ObterPorId(request.ClienteId));

              //  orcamentoNovo.Numero = _repositoryOrcamento.Listar().OrderByDescending(x => x.Numero).Select(x => x.Numero).FirstOrDefault<Int64>() + 1;

                AddNotifications(orcamentoNovo);


                if (IsInvalid()) return;

                _repositoryOrcamento.Adicionar(orcamentoNovo);
                return;
            }
            catch
            {
                AddNotification("AdicionarAlterar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AdicionarAlterar"));
                return;
            }
        }

        public void Excluir(long numero)
        {
            try
            {
                var orcamento = _repositoryOrcamento.ObterPor(x => x.Numero == numero, x => x.Itens);

                if (orcamento == null)
                {
                    AddNotification("Orcamento", MSG.X0_NAO_ENCONTRADO.ToFormat("Orçamento"));
                    return;
                }

                _repositoryOrcamento.Remover(orcamento);
            }
            catch (Exception ex)
            {
                AddNotification("Orcamento", MSG.NAO_E_POSSIVEL_EXCLUIR_ESTE_X0.ToFormat("orçamento") + ex);
                return;
            }
        }

        public List<OrcamentoResponse> Listar(string cliente)
        {
            try
            {
                var orcamentos = new List<Orcamento>();

                if (cliente == "")
                    orcamentos = _repositoryOrcamento.Listar(x => x.Cliente, x => x.Itens).ToList();
                else
                    orcamentos = _repositoryOrcamento.ListarPor(x => x.Cliente.Nome.StartsWith(cliente)).ToList();

                return ProdutosResponse(orcamentos).OrderBy(x => x.DataCriacao).ToList();
            }
            catch
            {
                AddNotification("Listar", MSG.ERRO_LISTAR_X0.ToFormat("Orcamento"));
                return null;
            }
        }


        private List<OrcamentoResponse> ProdutosResponse(List<Orcamento> orcamentos)
        {
            try
            {
                var orcamentosResponse = new List<OrcamentoResponse>();
                foreach (var orcamento in orcamentos)
                {
                    var orcamentoNovo = new OrcamentoResponse();
                    var itens = new List<OrcamentoItensResponse>();

                    orcamentoNovo.Id = orcamento.Id;
                    orcamentoNovo.Cliente = (ClienteResponse)orcamento.Cliente;
                    orcamentoNovo.NomeCliente = orcamentoNovo.Cliente.Nome;
                    orcamentoNovo.Numero = orcamento.Numero;
                    orcamentoNovo.Observacao = orcamento.Observacao;
                    orcamentoNovo.ValorAcrescimo = orcamento.ValorAcrescimo;
                    orcamentoNovo.ValorDesconto = orcamento.ValorDesconto;
                    orcamentoNovo.ValorTotal = orcamento.ValorTotal;
                    orcamentoNovo.ExisteOrdemServico = orcamento.ExisteOrdemServico;
                    orcamentoNovo.FormaPagamento = orcamento.FormaPagamento;
                    orcamentoNovo.DataCriacao = orcamento.DataCriacao;

                    foreach (var item in orcamento.Itens)
                    {
                        var itemNovo = new OrcamentoItensResponse();
                        itemNovo.Id = item.Id;
                        itemNovo.ProdutoServico = (ProdutoServicoResponse)_repositoryProdutoServico.ObterPorId(item.ProdutoServicoId);

                        itens.Add(itemNovo);
                    }

                    orcamentoNovo.Itens = itens;
                    orcamentosResponse.Add(orcamentoNovo);
                }

                return orcamentosResponse;
            }
            catch
            {
                return null;
            }

        }
        public OrcamentoResponse Obter_ByNumero(Int64 numero)
        {
            try
            {
                return ProdutosResponse(_repositoryOrcamento.ListarPor(x => x.Numero == numero).ToList()).FirstOrDefault();
            }
            catch
            {
                AddNotification("Obter_ByNumero", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Obter_ByNumero"));
                return null;
            }
        }
    }
}
