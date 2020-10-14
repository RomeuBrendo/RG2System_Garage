using RG2System_Garage.Domain.Commands.Configuracao;
using RG2System_Garage.Domain.Interfaces.Services.Base;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceConfiguracaoDadosEmpresa : IServiceBase
    {
        void AdicionarAlterar(DadosEmpresaRequest request);

        DadosEmpresaResponse ObterDadosEmpresa();
    }
}
