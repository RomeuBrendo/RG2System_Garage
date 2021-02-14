using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceOrdemServico : IServiceBase
    {
        void AdicionarAlterar(OrdemServicoRequest request);
        List<OrdemServicoResponse> Listar();
    }
}
