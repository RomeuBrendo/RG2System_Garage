using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Commands.Veiculo;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceCliente : IServiceBase
    {
        bool AdicionarAlterar(ClienteRequest request);

        List<ClienteResponse> Listar(string nome);

        bool Deletar(Guid id);

        ClienteResponse ObterClienteId(Guid id);

        List<VeiculoResponse> ListarVeiculos_byCliente(Guid id);

    }
}
