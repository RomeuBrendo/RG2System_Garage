using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceProduto : IServiceBase
    {
        bool AdionarAlterar(AdionarAlterarProdutoRequest request);

        List<ProdutoResponse> Listar(string descricao);

        bool Deletar(Guid id);

        ProdutoResponse ObterProdutoId(Guid id);
    }
}
