using Microsoft.EntityFrameworkCore;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente, Guid>, IRepositoyCliente
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryCliente(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }

        public bool InserirPlacas(ClienteVeiculoLista clienteVeiculos)
        {
            try
            {
                var veiculos = _context.ClienteVeiculo.Where(x => x.Cliente.Id == clienteVeiculos[0].Cliente.Id);
                _context.ClienteVeiculo.RemoveRange(veiculos);
                _context.ClienteVeiculo.AddRange(clienteVeiculos);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Veiculo> ListarVeiculosByCliente(Guid idCliente)
        {
            try
            {
                return _context.ClienteVeiculo.Where(x => x.Cliente.Id == idCliente)
                                                           .Include(x => x.Veiculo)
                                                           .Select(x => x.Veiculo).ToList();
            }
            catch
            {

                return null;
            }
        }

        public void RemoverVeiculosCliente(Guid idCliente)
        {
            try
            {
                var veiculos = _context.ClienteVeiculo.Where(x => x.Cliente.Id == idCliente);
                _context.ClienteVeiculo.RemoveRange(veiculos);
            }
            catch
            {
                return;
            }
        }

    }
}
