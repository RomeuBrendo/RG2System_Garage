using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;
using System.Linq;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryFormaPagamento : RepositoryBase<FormaPagamento, Guid>, IRepositoryFormaPagamento
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryFormaPagamento(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }

        public string ReturnDescricaoPagamento_ById(Guid id)
        {
            try
            {
                return _context.FormaPagamentos.Where(x => x.Id == id).Select(x => x.Descricao).FirstOrDefault();
            }
            catch
            {
                return "";
            }
        }
    }
}
