using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
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
    public class ServiceProduto : Notifiable, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }

        public bool AdionarAlterar(AdionarAlterarProdutoRequest request)
        {
            try
            {
                if (request == null)
                {
                    AddNotification("Resquest", MSG.X0_INVALIDO.ToFormat("Request"));
                }
                if ((request.Id != null) && (request.Id != Guid.Empty)) //Alteração
                {
                    var produto = _repositoryProduto.ObterComEstoqueProdutoAtual(request.Id.Value);
                    AddNotifications(produto);

                    if (produto == null)
                    {
                        AddNotification("Produto", MSG.DADOS_NAO_ENCONTRADOS);
                        return false;
                    }

                    var estoque = new EstoqueProduto(produto.Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque);

                    if ((estoque.EstoqueAtual != produto.EstoqueProduto.EstoqueAtual) ||
                        (estoque.PrecoCusto != produto.EstoqueProduto.PrecoCusto) ||
                        (estoque.PrecoVenda != produto.EstoqueProduto.PrecoVenda))
                    {
                        //Sempre que alterado Estoque ou Preços, é inserido um novo registro para manter o estoque
                        _repositoryProduto.InserirRegistroEstoqueProduto(estoque);

                    }
                    
                    AddNotifications(estoque);

                    //Altera somente descrição
                    produto.AlterarProduto(request);

                    if (IsInvalid()) return false;

                    _repositoryProduto.Editar(produto);
                    return true;
                }

                var produtoNovo = new Produto(request);
               
                AddNotifications(produtoNovo);

                if (IsInvalid()) return false;

                _repositoryProduto.Adicionar(produtoNovo);

                return true;

            }
            catch
            {
                AddNotification("Produto", MSG.DADOS_NAO_ENCONTRADOS);
                return false;
            }
        }

        public List<ProdutoResponse> Listar(string descricao)
        {
            try
            {
                var produtos = new List<ProdutoResponse>();
                if (descricao != "")
                    produtos = ProdutosResponse(_repositoryProduto.ListarPor(x => x.Descricao.StartsWith(descricao)).ToList());
                else
                    produtos = ProdutosResponse(_repositoryProduto.Listar(x => x.FichaEstoqueProduto).ToList());

                return produtos;

            }
            catch
            {

                AddNotification("Listar", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        private List<ProdutoResponse> ProdutosResponse(List<Produto> produtos)
        {
            try
            {
                var produtosResponse = new List<ProdutoResponse>();
                foreach (var item in produtos)
                {
                    var produtoNovo = new ProdutoResponse();
                    var ultimoEstoqueProduto = item.FichaEstoqueProduto.OrderByDescending(x => x.DataLancamento).ToList().FirstOrDefault();
                    
                    produtoNovo.Id = item.Id;
                    produtoNovo.Descricao = item.Descricao;
                    produtoNovo.Estoque = ultimoEstoqueProduto.EstoqueAtual;
                    produtoNovo.PrecoCusto = ultimoEstoqueProduto.PrecoCusto;
                    produtoNovo.PrecoVenda = ultimoEstoqueProduto.PrecoVenda;

                    produtosResponse.Add(produtoNovo);
                }

                return produtosResponse;
            }
            catch(Exception ex)
            {

                return null;
            }

        }

        public bool Deletar(Guid id)
        {
            try
            {
                _repositoryProduto.Remover(_repositoryProduto.ObterPorId(id));
                return true;

            }
            catch
            {

                AddNotification("Erro", "Deletar produto");
                return false;
            }
        }

        public ProdutoResponse ObterProdutoId(Guid id)
        {
            try
            {
                return (ProdutoResponse)_repositoryProduto.ObterPorId(id);
            }
            catch
            {
                AddNotification("Produto", MSG.ERRO_REALIZAR_PROCEDIMENTO);
                return null;
            }
        }
    }
}
