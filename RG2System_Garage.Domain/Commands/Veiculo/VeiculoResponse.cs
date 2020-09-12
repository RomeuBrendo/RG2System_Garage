using System;

namespace RG2System_Garage.Domain.Commands.Veiculo
{
    public class VeiculoResponse
    {
        public Guid? Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }

        public static explicit operator VeiculoResponse(Entities.Veiculo v)
        {
            return new VeiculoResponse()
            {
                Id = v.Id,
                Placa = v.Placa,
                Modelo = v.Modelo,
                Ano = v.Ano
            };
        }
    }
}
