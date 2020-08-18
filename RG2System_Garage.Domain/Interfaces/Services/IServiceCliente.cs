using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceCliente : IServiceBase
    {
        bool AdicionarAlterar(AdicionarAlterarClienteRequest request);

        List<ClienteResponse> Listar(string nome);

        bool Deletar(int id);
        
    }
}
