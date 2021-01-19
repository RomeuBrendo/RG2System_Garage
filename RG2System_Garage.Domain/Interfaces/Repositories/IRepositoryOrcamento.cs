using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Interfaces.Repositories
{
    public interface IRepositoryOrcamento : IRepositoryBase<Orcamento, Guid>
    {
        bool ExcluirItens(Guid id);
        bool AdicionarItens(List<OrcamentoItem> itens);
    }
}
