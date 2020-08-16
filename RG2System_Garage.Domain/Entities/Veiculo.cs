using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public  class Veiculo : EntityBase
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public string Cliente { get; private set; }
    }
}
