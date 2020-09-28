using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class EstoqueProduto : EntityBase
    {
        protected EstoqueProduto()
        {

        }
        public EstoqueProduto(Guid produtoId, DateTime dataLancamento, float precoCusto, float precoVenda, int estoqueAtual)
        {
            this.ClearNotifications();
            ProdutoId = produtoId;
            DataLancamento = dataLancamento;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            EstoqueAtual = estoqueAtual;

            new AddNotifications<EstoqueProduto>(this)
                .IfEqualsZero(x => x.PrecoCusto, MSG.O_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Preço de Custo", "0,1"))
                .IfEqualsZero(x => x.PrecoVenda, MSG.O_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Preço de Venda", "0,1"));
        }

        public Guid ProdutoId { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public float PrecoCusto { get; private set; }
        public float PrecoVenda { get; private set; }
        public int EstoqueAtual { get; private set; }
    }
}
