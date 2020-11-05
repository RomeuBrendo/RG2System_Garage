using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceProduto : Notifiable, IServiceProduto
    {
        private readonly IRepositoryProdutoServico _repositoryProdutoServico;

        public ServiceProduto(IRepositoryProdutoServico repositoryProdutoServico)
        {
            _repositoryProdutoServico = repositoryProdutoServico;
        }

        public bool AdionarAlterar(AdionarAlterarProdutoServicoRequest request)
        {
            try
            {
                if (request == null)
                {
                    AddNotification("Resquest", MSG.X0_INVALIDO.ToFormat("Request"));
                }
                if ((request.Id != null) && (request.Id != Guid.Empty)) //Alteração
                {
                    var produto = _repositoryProdutoServico.ObterComEstoqueProdutoAtual(request.Id.Value);

                    if (produto == null)
                    {
                        AddNotification("Produto", MSG.DADOS_NAO_ENCONTRADOS);
                        return false;
                    }

                    var estoque = new Movimentacao(produto.Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque);

                    if ((estoque.EstoqueAtual != produto.UltimaMovimentacao.EstoqueAtual) ||
                        (estoque.PrecoCusto != produto.UltimaMovimentacao.PrecoCusto) ||
                        (estoque.PrecoVenda != produto.UltimaMovimentacao.PrecoVenda))
                    {
                        //Sempre que alterado Estoque ou Preços, é inserido um novo registro para manter o estoque
                        _repositoryProdutoServico.InserirRegistroMovimentacao(estoque);

                    }
                    
                    AddNotifications(estoque);

                    //Altera somente descrição
                    produto.AlterarProduto(request);

                    if (IsInvalid()) return false;

                    _repositoryProdutoServico.Editar(produto);
                    return true;
                }

                var produtoNovo = new ProdutoServico(request);
               
                AddNotifications(produtoNovo);

                if (IsInvalid()) return false;

                _repositoryProdutoServico.Adicionar(produtoNovo);

                return true;

            }
            catch
            {
                AddNotification("Produto", MSG.DADOS_NAO_ENCONTRADOS);
                return false;
            }
        }

        public List<ProdutoServicoResponse> Listar(string descricao)
        {
            try
            {
                this.ClearNotifications();
                var produtos = new List<ProdutoServicoResponse>();
                if (descricao != "")
                    produtos = ProdutosResponse(_repositoryProdutoServico.ListarPor(x => x.Descricao.StartsWith(descricao)).ToList());
                else
                    produtos = ProdutosResponse(_repositoryProdutoServico.Listar(x => x.FichaMovimentacao).ToList());

                return produtos;

            }
            catch
            {

                AddNotification("Listar", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        public List<ProdutoServicoResponse> ListarProdutoOuServico(EnumTipo enumTipo)
        {
            try
            {
                this.ClearNotifications();

                if (enumTipo == EnumTipo.Produto)
                    return ProdutosResponse(_repositoryProdutoServico.ListarPor(x => x.Tipo == EnumTipo.Produto, j => j.FichaMovimentacao).OrderBy(x => x.Descricao).ToList());
                else
                    return ProdutosResponse(_repositoryProdutoServico.ListarPor(x => x.Tipo == EnumTipo.Servico, j => j.FichaMovimentacao).OrderBy(x => x.Descricao).ToList());
            }
            catch
            {
                AddNotification("ListarProduto", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        private List<ProdutoServicoResponse> ProdutosResponse(List<ProdutoServico> produtos)
        {
            try
            {
                var produtosResponse = new List<ProdutoServicoResponse>();
                foreach (var item in produtos)
                {
                    var produtoNovo = new ProdutoServicoResponse();
                    var ultimoEstoqueProduto = item.FichaMovimentacao.OrderByDescending(x => x.DataLancamento).ToList().FirstOrDefault();
                    
                    produtoNovo.Id = item.Id;
                    produtoNovo.Tipo = item.Tipo;

                    if (produtoNovo.Tipo == Enum.EnumTipo.Servico)
                        produtoNovo.TipoDescricao = "Serviço";
                    else
                        produtoNovo.TipoDescricao = "Produto";

                    produtoNovo.Descricao = item.Descricao;
                    produtoNovo.Estoque = ultimoEstoqueProduto.EstoqueAtual;
                    produtoNovo.PrecoCusto = ultimoEstoqueProduto.PrecoCusto;
                    produtoNovo.PrecoVenda = ultimoEstoqueProduto.PrecoVenda;

                    produtosResponse.Add(produtoNovo);
                }

                return produtosResponse;
            }
            catch
            {
                return null;
            }

        }

        public bool Deletar(Guid id)
        {
            try
            {
                _repositoryProdutoServico.Remover(_repositoryProdutoServico.ObterPorId(id));
                return true;

            }
            catch
            {

                AddNotification("Erro", MSG.NAO_E_POSSIVEL_EXCLUIR_ESTE_X0.ToFormat("Produto/Serviço"));
                return false;
            }
        }

        public ProdutoServicoResponse ObterProdutoId(Guid id)
        {
            try
            {
                return (ProdutoServicoResponse)_repositoryProdutoServico.ObterPorId(id);
            }
            catch
            {
                AddNotification("Produto", MSG.ERRO_REALIZAR_PROCEDIMENTO);
                return null;
            }
        }
    }
}
