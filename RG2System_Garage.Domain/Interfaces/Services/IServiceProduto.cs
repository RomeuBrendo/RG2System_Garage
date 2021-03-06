﻿using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceProduto : IServiceBase
    {
        bool AdionarAlterar(AdionarAlterarProdutoServicoRequest request);

        List<ProdutoServicoResponse> Listar(string descricao);

        bool Deletar(Guid id);

        ProdutoServicoResponse ObterProdutoId(Guid id);
        
        List<ProdutoServicoResponse> ListarProdutoOuServico(EnumTipo enumTipo);
    }
}
