using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Services
{
    public interface IServiceFormaPagamento : IServiceBase
    {
        void AdicionarAlterar(FormaPagamentoRequest request);
        List<FormaPagamentoResponse> Listar(string descricao);
        void Excluir(Guid id);
    }
}
