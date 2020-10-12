using Microsoft.EntityFrameworkCore.Query.Internal;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;

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

        private void ProdutoBase(AdionarAlterarProdutoRequest request)
        {
            Descricao = request.Descricao;

            EstoqueProduto.Add(new EstoqueProduto(Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque));

            AddNotifications(EstoqueProduto);

            new AddNotifications<Produto>(this)
                .IfNullOrInvalidLength(x => x.Descricao, 2, 50, MSG.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Descrição", "2", "50"));

        }
        public void AlterarProduto(AdionarAlterarProdutoRequest request)
        {
            this.ClearNotifications();
            Id = request.Id.Value;
            Descricao = request.Descricao;
            //ProdutoBase(request);
        }

        public void AlterarEstoqueProduto(List<EstoqueProduto> request)
        {
            this.ClearNotifications();
            EstoqueProduto = request;
            AddNotifications(EstoqueProduto);
        }
        public string Descricao { get; private set; }

        public List<EstoqueProduto> EstoqueProduto { get; private set; }

    }
}
