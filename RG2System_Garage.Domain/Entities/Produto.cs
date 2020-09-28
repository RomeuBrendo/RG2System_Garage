using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(AdionarAlterarProdutoRequest request)
        {
            this.ClearNotifications();
            ProdutoBase(request);
        }

        private void ProdutoBase(AdionarAlterarProdutoRequest request)
        {
            Descricao = request.Descricao;

            EstoqueProduto = new EstoqueProduto(Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque);

            AddNotifications(EstoqueProduto);

            new AddNotifications<Produto>(this)
                .IfNullOrInvalidLength(x => x.Descricao, 2, 50, MSG.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Descrição", "2", "50"));

        }
        public void AlterarProduto(AdionarAlterarProdutoRequest request)
        {
            this.ClearNotifications();
            Id = request.Id.Value;
            ProdutoBase(request);
        }
        public Produto(string descricao,  Guid id)
        {
            Id = id;
            Descricao = descricao;

            new AddNotifications<Produto>(this)
                 .IfNullOrInvalidLength(x => x.Descricao, 2, 50, "O campo descrição deve conter entre 2 e 50 caracteres");

            //if (id < 1)
            //    AddNotification("Id", "Para realizar alteração, é necessario passar um ID valido");
        }

        public string Descricao { get; private set; }

        public EstoqueProduto EstoqueProduto { get; private set; }

    }
}
