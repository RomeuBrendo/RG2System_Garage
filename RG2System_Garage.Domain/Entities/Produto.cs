using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Entities
{
    public class Produto : EntityBase
    {
        protected Produto()
        {

        }
        public Produto(AdionarAlterarProdutoRequest request)
        {
            this.ClearNotifications();
            ProdutoBase(request);
        }

        public Produto(List<EstoqueProduto> estoqueProduto)
        {
            FichaEstoqueProduto = estoqueProduto;
        }

        private void ProdutoBase(AdionarAlterarProdutoRequest request)
        {
            Descricao = request.Descricao;

            //var estoqueProduto = new EstoqueProduto(Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque);

            var estoqueProdutos = new List<EstoqueProduto>();
            
            estoqueProdutos.Add(new EstoqueProduto(Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque));
            
            FichaEstoqueProduto = estoqueProdutos;
            AddNotifications(FichaEstoqueProduto);
            ValidaDescricao();

        }

        private void ValidaDescricao()
        {
            new AddNotifications<Produto>(this)
                .IfNullOrInvalidLength(x => x.Descricao, 2, 50, MSG.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Descrição", "2", "50"));

        }
        public void AlterarProduto(AdionarAlterarProdutoRequest request)
        {
            this.ClearNotifications();
            Id = request.Id.Value;
            Descricao = request.Descricao;
            ValidaDescricao();
        }

        public void AlterarPropriedade(Produto request)
        {
            //Trecho abaixo é apenas para modificar propriedade quando nã quero o historico da tabela estoque produto, e sim somente o atual que no caso é o último.
            EstoqueProduto = request.FichaEstoqueProduto.OrderByDescending(x => x.DataLancamento).FirstOrDefault();
        }

        public void AlterarEstoqueProduto(List<EstoqueProduto> request)
        {
            this.ClearNotifications();
            FichaEstoqueProduto = request;
            AddNotifications(FichaEstoqueProduto);
        }
        public string Descricao { get; private set; }

        public List<EstoqueProduto> FichaEstoqueProduto { get; private set; }

        public EstoqueProduto EstoqueProduto { get; set; }

    }
}
