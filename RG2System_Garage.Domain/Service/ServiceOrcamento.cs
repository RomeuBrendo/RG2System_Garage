using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Commands.Veiculo;
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
        private readonly IRepositoryVeiculo _repositoryVeiculo;
        private readonly IRepositoryProdutoServico _repositoryProdutoServico;

        public ServiceOrcamento(IRepositoryOrcamento repositoryOrcamento, IRepositoyCliente repositoyCliente, IRepositoryProdutoServico repositoryProdutoServico, IRepositoryVeiculo repositoryVeiculo)
        {
            _repositoryOrcamento = repositoryOrcamento;
            _repositoyCliente = repositoyCliente;
            _repositoryProdutoServico = repositoryProdutoServico;
            _repositoryVeiculo = repositoryVeiculo;
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

                    if (!_repositoryOrcamento.ExcluirItens(request.Id.Value))
                        AddNotification("Itens", "Erro ao atualizar itens");

                    if (!_repositoryOrcamento.AdicionarItens(PopularItens(request.Itens)))
                        AddNotification("Itens", "Erro ao atualizar itens");

                    orcamento.Alterar(request);

                    AddNotifications(orcamento);

                    if (IsInvalid()) return;

                    _repositoryOrcamento.Editar(orcamento);
                    
                    return;
                }
                var cliente = _repositoyCliente.ObterPorId(request.ClienteId);

                var veiculo = _repositoryVeiculo.ObterPorId(request.VeiculoId);

                var orcamentoNovo = new Orcamento(request, cliente, veiculo);

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

        public List<OrcamentoItem> PopularItens(List<OrcamentoItensRequest> request)
        {
            try
            {
                var itensNovos = new List<OrcamentoItem>();
                foreach (var item in request)
                {
                    var itemNovo = new OrcamentoItem(item.OrcamentoId, item.ProdutoServicoId, item.PrecoVenda.ToString(), item.Quantidade);
                    AddNotifications(itemNovo);

                    itensNovos.Add(itemNovo);
                }

                return itensNovos;
            }
            catch 
            {
                AddNotification("Itens", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Inserção itens"));
                return null;
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
            return ProdutosResponse(orcamentos, false);
        }
        private List<OrcamentoResponse> ProdutosResponse(List<Orcamento> orcamentos, bool carregarVeiculo)
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
                    
                    if (carregarVeiculo)
                        orcamentoNovo.Veiculo = (VeiculoResponse)_repositoryVeiculo.ObterPorId(orcamento.Veiculo.Id);

                    orcamentoNovo.NomeCliente = orcamentoNovo.Cliente.Nome;
                    orcamentoNovo.Numero = orcamento.Numero;
                    orcamentoNovo.Observacao = orcamento.Observacao;
                    orcamentoNovo.ValorAcrescimo = orcamento.ValorAcrescimo;
                    orcamentoNovo.ValorDesconto = orcamento.ValorDesconto;
                    orcamentoNovo.ValorTotal = orcamento.ValorTotal;
                    orcamentoNovo.ExisteOrdemServico = _repositoryOrcamento.ExisteOR(orcamento.Id);
                    orcamentoNovo.DataCriacao = orcamento.DataCriacao;

                    foreach (var item in orcamento.Itens)
                    {
                        var itemNovo = new OrcamentoItensResponse();
                        itemNovo.OrcamentoId = item.OrcamentoId;
                        var produtoServico = _repositoryProdutoServico.ObterPorId(item.ProdutoServicoId, x => x.FichaMovimentacao); //Futuramente será necessario melhorar este bloco
                        itemNovo.ProdutoServico = (ProdutoServicoResponse)produtoServico;
                        itemNovo.PrecoVenda = Decimal.Parse(item.PrecoVenda.ToString());
                        itemNovo.Quantidade = item.Quantidade;
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
                return ProdutosResponse(_repositoryOrcamento.ListarPor(x => x.Numero == numero, x => x.Cliente, x => x.Veiculo, x => x.Itens).ToList(), true).FirstOrDefault();
            }
            catch
            {
                AddNotification("Obter_ByNumero", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Obter_ByNumero"));
                return null;
            }
        }
    }
}
