using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Repositories
{
    public interface IRepositoyCliente : IRepositoryBase<Cliente, Guid>
    {
        bool InserirPlacas(ClienteVeiculoLista clienteVeiculos);
        List<Veiculo> ListarVeiculosByCliente(Guid idCliente);
    }
}
