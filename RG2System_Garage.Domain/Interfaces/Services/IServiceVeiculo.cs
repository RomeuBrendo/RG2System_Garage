﻿using RG2System_Garage.Domain.Commands.Veiculo;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceVeiculo : IServiceBase
    {
        bool AdicionarOuAlterar(VeiculoRequest veiculoRequest);
        List<VeiculoResponse> ListarVeiculo(string placa);
        VeiculoResponse ObterVeiculoId(Guid id);

        void Excluir(Guid id);
    }
}
