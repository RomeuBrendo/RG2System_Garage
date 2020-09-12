using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using System;

namespace RG2System_Garage.Domain.Interfaces.Repositories
{
    public interface IRepositoryVeiculo : IRepositoryBase<Veiculo, Guid>
    {
    }
}
