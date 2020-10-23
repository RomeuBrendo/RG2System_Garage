using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceOrcamento : IServiceBase
    {
        void AdicionarAlterar(OrcamentoRequest request);
        List<OrcamentoResponse> Listar(string cliente);
        OrcamentoResponse Obter_ByNumero(Int64 numero);
        void Excluir(Int64 numero);
    }
}
