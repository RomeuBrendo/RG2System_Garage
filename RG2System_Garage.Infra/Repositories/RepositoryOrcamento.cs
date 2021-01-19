using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryOrcamento : RepositoryBase<Orcamento, Guid>, IRepositoryOrcamento
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryOrcamento(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }

        public bool ExcluirItens(Guid id)
        {
            try
            {
                var itens = _context.OrcamentoItens.Where(x => x.OrcamentoId == id);
                _context.OrcamentoItens.RemoveRange(itens);
                return true;
            }
            catch
            {

                return false; ;
            }
        }

        public bool AdicionarItens(List<OrcamentoItem> itens)
        {
            try
            {
                _context.OrcamentoItens.AddRange(itens);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
