using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
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
                if (request.Id != null)
                {
                    var produto = new Produto(request);

                    AddNotifications(produto);

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
                    produtos = ProdutosResponse(_repositoryProduto.Listar().Include(x => x.EstoqueProduto).ToList());

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
                    produtoNovo.Estoque = item.EstoqueProduto.EstoqueAtual;
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
    }
}
