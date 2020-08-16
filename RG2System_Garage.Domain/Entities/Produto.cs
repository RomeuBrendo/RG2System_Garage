using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string Descricao { get; private set; }
        public int Estoque { get; private set; }
    }
}
