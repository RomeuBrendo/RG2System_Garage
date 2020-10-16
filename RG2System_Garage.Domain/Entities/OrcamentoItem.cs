using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public class OrcamentoItem : EntityBase
    {
        protected OrcamentoItem()
        {

        }
        public Orcamento Orcamento { get; set; }
        public Produto Produto { get; set; }
    }
}
