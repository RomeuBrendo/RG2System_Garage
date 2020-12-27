using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class OrcamentoItem : EntityBase
    {
        protected OrcamentoItem()
        {

        }
        public OrcamentoItem(Guid orcamentoId, Guid produtoServicoId, string precoVenda, int quantidade)
        {
            this.ClearNotifications();
            OrcamentoId = orcamentoId;
            ProdutoServicoId = produtoServicoId;

            Quantidade = quantidade;

            //new AddNotifications<OrcamentoItem>(this)
            //    .IfEqualsZero(x => x.Quantidade, MSG.A_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Quantidade do produto", "1"));
            //new AddNotifications<OrcamentoItem>(this)
            //    .IfNull(x => x.OrcamentoId, MSG.X0_INVALIDO.ToFormat("Orçamento"))
            //    .IfNull(x => x.ProdutoServicoId);

            try
            {
                PrecoVenda = float.Parse(precoVenda);
            }
            catch
            {
                AddNotification("PrecoVenda", MSG.X0_INVALIDO.ToFormat("Preço Venda"));
                PrecoVenda = 1;
            }

        }

    
        public Guid OrcamentoId { get; private set; }
        public Guid ProdutoServicoId { get; private set; }
        public float PrecoVenda { get; private set; }
        public int Quantidade { get; private set; }
    }
}
