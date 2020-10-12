using Microsoft.EntityFrameworkCore;
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
using System.Security.Cryptography.X509Certificates;

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
                if (request.Id != null) //Alteração
                {
                    var produto = _repositoryProduto.ObterPorId(request.Id.Value, x => x.EstoqueProduto);
                    produto.AlterarProduto(request);

                    AddNotifications(produto);

                    if (IsInvalid()) return false;

                    var estoque = new EstoqueProduto(produto.Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque);

                    if (IsInvalid()) return false;

                    //if ((estoque.EstoqueAtual != produto.EstoqueProduto.EstoqueAtual) ||
                    //    (estoque.PrecoCusto != produto.EstoqueProduto.PrecoCusto) ||
                    //    (estoque.PrecoVenda != produto.EstoqueProduto.PrecoVenda))
                    //{
                    //      _repositoryProduto.InserirRegistroEstoqueProduto(estoque);
                    //    //produto.AlterarEstoqueProduto(estoque);
                    //}
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
                AddNotification("Erro", "Não foi possivél realizar Alteração/Inserção");
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
                    //produtos = ProdutosResponse(_repositoryProduto.ListarPor(x => x.Id != null)).ToList();

                return produtos;

            }
            catch
            {

                AddNotification("Erro", "Ao realizar consulta no banco");
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

                    produtoNovo.Id = item.Id;
                    produtoNovo.Descricao = item.Descricao;
                    produtoNovo.Estoque = item.EstoqueProduto.OrderByDescending(x => x.DataLancamento).Select(x => x.EstoqueAtual).FirstOrDefault();
                    produtoNovo.PrecoCusto = item.EstoqueProduto.PrecoCusto;
                    produtoNovo.PrecoVenda = item.EstoqueProduto.PrecoVenda;


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
