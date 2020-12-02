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
        public OrcamentoItem(Guid orcamentoId, Guid produtoServicoId, string precoVenda)
        {
            this.ClearNotifications();
            OrcamentoId = orcamentoId;
            ProdutoServicoId = produtoServicoId;

            new AddNotifications<OrcamentoItem>(this)
                .IfNull(x => x.OrcamentoId, MSG.X0_INVALIDO.ToFormat("Orçamento"))
                .IfNull(x => x.ProdutoServicoId);

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
    }
}
