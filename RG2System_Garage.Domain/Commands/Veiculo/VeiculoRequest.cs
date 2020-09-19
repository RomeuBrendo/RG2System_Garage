using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.Veiculo
{
    public class VeiculoRequest
    {
        public Guid? Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }

        public List<VeiculoRequest> VeiculoPRequest(List<VeiculoResponse> response)
        {
            if (response == null)
                return null;

            var veiculosRequest = new List<VeiculoRequest>();
            foreach (var item in response)
            {
                var veiculo = new VeiculoRequest();
                veiculo.Id = item.Id;
                veiculo.Modelo = item.Modelo;
                veiculo.Placa = item.Placa;
                veiculo.Ano = item.Ano;
                veiculosRequest.Add(veiculo);
            }

            return veiculosRequest;
        }
    }
}
