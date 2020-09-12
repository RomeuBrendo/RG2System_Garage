using System;

namespace RG2System_Garage.Domain.Commands.Veiculo
{
    public class VeiculoRequest
    {
        public Guid? Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
    }
}
