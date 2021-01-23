using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Interfaces.Services.Base;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceOrdemServico : IServiceBase
    {
        void AdicionarAlterar(OrdemServicoRequest request);
    }
}
