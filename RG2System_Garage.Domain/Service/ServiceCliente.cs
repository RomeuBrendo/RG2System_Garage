using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceCliente : Notifiable, IServiceCliente
    {
        private readonly IRepositoyCliente _repositoryCliente;

        public ServiceCliente(IRepositoyCliente repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public bool AdicionarAlterar(AdicionarAlterarClienteRequest request)
        {
            try
            {
                if(request.Id > 0)
                {
                    var cliente = new Cliente(request.Nome);
                    
                    AddNotifications(cliente);

                    if (IsInvalid()) return false;

                    _repositoryCliente.Editar(cliente);
                 
                }
                else
                {
                    var cliente = new Cliente(request.Nome);
                    
                    AddNotifications(cliente);

                    if (IsInvalid()) return false;

                    _repositoryCliente.Adicionar(cliente);
                }

                return true;
            }
            catch
            {

                AddNotification("AdicionarOuAlterar", "Erro ao atualizar Cliente. Tente novamente.");
                return false;
            }
        }

        public bool Deletar(int id)
        {
            try
            {
                _repositoryCliente.Remover(_repositoryCliente.ObterPorId(id));
                return true;
            }
            catch
            {

                AddNotification("Erro", "Deletar cliente");
                return false;
            }
        }

        public List<ClienteResponse> Listar(string nome)
        {
            try
            {
                var clientes = new List<ClienteResponse>();
                if (nome != "")
                    clientes = ClientesResponse(_repositoryCliente.ListarPor(x => x.Nome.StartsWith(nome)).ToList());
                else
                    clientes = ClientesResponse(_repositoryCliente.Listar().ToList());

                return clientes;
            }
            catch
            {

                throw;
            }
        }

        private List<ClienteResponse> ClientesResponse(List<Cliente> clientes)
        {
            try
            {
                var ClientesResponse = new List<ClienteResponse>();
                foreach (var item in clientes)
                {
                    var clienteNovo = new ClienteResponse();

                    clienteNovo.Id = item.Id;
                    clienteNovo.Nome = item.Nome;
                    ClientesResponse.Add(clienteNovo);
                }

                return ClientesResponse;
            }
            catch
            {

                return null;
            }

        }

    }
}
