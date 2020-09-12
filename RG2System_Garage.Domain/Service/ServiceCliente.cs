using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
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

        public bool AdicionarAlterar(ClienteRequest request)
        {
            try
            {
                if(request.Id != null)
                {
                    var cliente = _repositoryCliente.ObterPorId(request.Id.Value);
                    cliente.AlterarCliente(request);

                    AddNotifications(cliente);

                    if (IsInvalid()) return false;

                    _repositoryCliente.Editar(cliente);
                 
                }
                else
                {
                    var cliente = new Cliente(request);
                    
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

        public bool Deletar(Guid id)
        {
            try
            {
                _repositoryCliente.Remover(_repositoryCliente.ObterPorId(id));
                return true;
            }
            catch
            {

                AddNotification("",MSG.NAO_E_POSSIVEL_EXCLUIR_ESTE_X0.ToFormat("Cliente"));
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
                    clienteNovo.CPFCNPJ = item.CPFCNPJ;
                    clienteNovo.Telefone1 = item.Telefone1;
                    clienteNovo.Telefone2 = item.Telefone2;

                    ClientesResponse.Add(clienteNovo);
                }

                return ClientesResponse;
            }
            catch
            {
                AddNotification("", MSG.ERRO_LISTAR_X0.ToFormat("Cliente"));
                return null;
            }

        }

    }
}
