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
        public OrcamentoItem(Guid orcamentoId, Guid produtoServicoId)
        {
            this.ClearNotifications();
            OrcamentoId = orcamentoId;
            ProdutoServicoId = produtoServicoId;

            new AddNotifications<OrcamentoItem>(this)
                .IfNull(x => x.OrcamentoId, MSG.X0_INVALIDO.ToFormat("Orçamento"))
                .IfNull(x => x.ProdutoServicoId);

        }

    
        public Guid OrcamentoId { get; private set; }
        public Guid ProdutoServicoId { get; private set; }
    }
}
