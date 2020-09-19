using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
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
    public class ServiceVeiculo : Notifiable, IServiceVeiculo
    {
        private readonly IRepositoryVeiculo  _repositoryVeiculo;

        public ServiceVeiculo(IRepositoryVeiculo repositoryVeiculo)
        {
            _repositoryVeiculo = repositoryVeiculo;
        }

        public bool AdicionarOuAlterar(VeiculoRequest veiculoRequest)
        {
            try
            {
                this.ClearNotifications();

                if (veiculoRequest.Id == null)
                {
                    var veiculo = new Veiculo(veiculoRequest.Placa, veiculoRequest.Modelo, veiculoRequest.Ano);

                    AddNotifications(veiculo);

                    if (_repositoryVeiculo.Existe(x => x.Placa == veiculo.Placa))
                        AddNotification("Placa", MSG.ESTA_X0_JA_EXISTE_CADASTRADA.ToFormat("Placa"));

                    if (!IsValid())
                        return false;

                    _repositoryVeiculo.Adicionar(veiculo);

                    return true;
                }
                else //Alterar
                {
                    var veiculo = _repositoryVeiculo.ObterPorId(veiculoRequest.Id.Value);
                    veiculo.AlterarVeiculo(veiculoRequest);

                    AddNotifications(veiculo);

                    if (!IsValid())
                        return false;

                    if (_repositoryVeiculo.Existe(x => x.Placa == veiculo.Placa && veiculo.Id != x.Id))
                    {
                        AddNotification("Placa", MSG.ESTA_X0_JA_EXISTE_CADASTRADA.ToFormat("Placa"));
                        return false;
                    }

                    _repositoryVeiculo.Editar(veiculo);
                    return true;
                }

            }
            catch
            {
                AddNotification("AdicionarOuAlterar","Erro ao atualizar Veiculo. Tente novamente.");
                return false;
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                this.ClearNotifications();
                if (id == null)
                {
                    AddNotification("Id", MSG.X0_INVALIDO.ToFormat("ID"));
                    return;
                }

                var veiculo = _repositoryVeiculo.ObterPorId(id);
                _repositoryVeiculo.Remover(veiculo);
            }
            catch
            {
                AddNotification("Id", MSG.NAO_E_POSSIVEL_EXCLUIR_ESTE_X0.ToFormat("Veículo"));
                return;
            }
        }

        public List<VeiculoResponse> ListarVeiculo(string placa)
        {
            try
            {

                this.ClearNotifications();
                var veiculos = new List<Veiculo>();
                if (placa != "")
                   veiculos = _repositoryVeiculo.ListarPor(x => x.Placa.StartsWith(placa)).ToList();
                else
                   veiculos = _repositoryVeiculo.Listar().ToList();


                if (veiculos != null)
                    return VeiculosResponse(veiculos);
                else
                    return null;
            }
            catch
            {

                AddNotification("Listar", MSG.ERRO_LISTAR_X0.ToFormat("Veículos"));
                return null;
            }

        }

        public VeiculoResponse ObterVeiculoId(Guid id)
        {
            try
            {
                this.ClearNotifications();
                var veiculo = _repositoryVeiculo.ObterPorId(id);

                if (veiculo == null)
                {
                    AddNotification("Veiculo", MSG.DADOS_NAO_ENCONTRADOS);
                    return null;
                }
                else
                    return (VeiculoResponse)veiculo;
            }
            catch
            {

                AddNotification("Veiculo", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        public VeiculoResponse ObterVeiculoPlaca(string placa)
        {
            try
            {
                this.ClearNotifications();
                var veiculo = _repositoryVeiculo.ObterPor(x => x.Placa == placa);

                if (veiculo == null)
                {
                    AddNotification("Veiculo", MSG.DADOS_NAO_ENCONTRADOS);
                    return null;
                }
                else
                    return (VeiculoResponse)veiculo;
            }
            catch
            {

                AddNotification("Veiculo", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }
        }

        private List<VeiculoResponse> VeiculosResponse(List<Veiculo> veiculos)
        {
            try
            {
                var veiculoResponse = new List<VeiculoResponse>();
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
            catch
            {
                return null;
            }

        }
    }
}
