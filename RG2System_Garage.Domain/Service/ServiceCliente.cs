using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Commands.Veiculo;
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
        private readonly IRepositoryVeiculo _repositoryVeiculo;

        public ServiceCliente(IRepositoyCliente repositoryCliente, IRepositoryVeiculo repositoryVeiculo)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryVeiculo = repositoryVeiculo;
        }

        public bool AdicionarAlterar(ClienteRequest request)
        {
            try
            {
                this.ClearNotifications();
                if (request.Id != null)
                {
                    var cliente = _repositoryCliente.ObterPorId(request.Id.Value);

                    if (cliente == null)
                    {
                        AddNotification("Cliente", MSG.DADOS_NAO_ENCONTRADOS);
                        return false;
                    }

                    cliente.AlterarCliente(request);

                    AddNotifications(cliente);

                    if (IsInvalid()) return false;

                    _repositoryCliente.Editar(cliente);
                    _repositoryCliente.InserirPlacas(PreenchaListaVeiculos(cliente, request.Veiculos));
                }
                else
                {
                    var cliente = new Cliente(request);
 

                    AddNotifications(cliente);

                    if (IsInvalid()) return false;

                    _repositoryCliente.Adicionar(cliente);
                    _repositoryCliente.InserirPlacas(PreenchaListaVeiculos(cliente, request.Veiculos));
                }

                return true;
            }
            catch
            {
                AddNotification("AdicionarOuAlterar", MSG.ERRO_REALIZAR_PROCEDIMENTO);
                return false;
            }
        }

        private ClienteVeiculoLista PreenchaListaVeiculos(Cliente cliente, List<VeiculoRequest> veiculos)
        {
            var clienteVeiculoLista = new ClienteVeiculoLista();

            if (veiculos != null)
            {
                foreach (var item in veiculos)
                {
                    var veiculo = _repositoryVeiculo.ObterPorId(item.Id.Value);
                    var clienteVeiculo = new ClienteVeiculo(cliente, veiculo);
                    clienteVeiculoLista.Add(clienteVeiculo);

                    AddNotifications(clienteVeiculo);
                }

                return clienteVeiculoLista;
            }
            return null;
        }

        public bool Deletar(Guid id)
        {
            try
            {
                _repositoryCliente.RemoverVeiculosCliente(id);
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
                AddNotification("Cliente", MSG.ERRO_LISTAR_X0.ToFormat("Clientes"));
                return null;
            }
        }

        private List<VeiculoResponse> ListarVeiculosByCliente(Guid id)
        {
            try
            {
                var veiculos = _repositoryCliente.ListarVeiculosByCliente(id);
                var veiculoResponse = new List<VeiculoResponse>();
                if (veiculos != null)
                {
                    foreach (var item in veiculos)
                    {
                        var veiculoNovo = new VeiculoResponse();
                        veiculoNovo.Id = item.Id;
                        veiculoNovo.Placa = item.Placa;
                        veiculoNovo.Modelo = item.Modelo;
                        veiculoResponse.Add(veiculoNovo);
                    }
                    return veiculoResponse;
                }
                else
                    AddNotification("Veiculo", MSG.ERRO_LISTAR_X0.ToFormat("Veículos"));

                return null;
            }
            catch
            {
                AddNotification("Veiculo", MSG.ERRO_LISTAR_X0.ToFormat("Veículos"));
                return null;
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

        public ClienteResponse ObterClienteId(Guid id)
        {
            try
            {
                this.ClearNotifications();
                var cliente = _repositoryCliente.ObterPor(x => x.Id == id);

                if (cliente == null)
                {
                    AddNotification("Veiculo", MSG.DADOS_NAO_ENCONTRADOS);
                    return null;
                }
                else
                {
                    var clienteCompleto = (ClienteResponse)cliente;
                    clienteCompleto.Veiculos = ListarVeiculosByCliente(clienteCompleto.Id.Value);
                    return clienteCompleto;
                }
                   
            }
            catch
            {
                AddNotification("cliente", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        public List<VeiculoResponse> ListarVeiculos_byCliente(Guid id)
        {
            try
            {
                return ListarVeiculosByCliente(id);
            }
            catch 
            {
                AddNotification("Veiculo", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Listar veiculos relacionado a este cliente."));
                return null;
            }
        }
    }
}
