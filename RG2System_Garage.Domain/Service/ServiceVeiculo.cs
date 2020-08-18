﻿using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Commands.Veiculo;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
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
                if (veiculoRequest.Id.Value > 0)
                {
                    var veiculo = new Veiculo(veiculoRequest.Placa, veiculoRequest.Modelo);

                    AddNotifications(veiculo);

                    if (IsValid())
                        return false;

                    _repositoryVeiculo.Adicionar(veiculo);

                    return true;
                }
                else //Alterar
                {
                    var vaeiculo = _repositoryVeiculo.ObterPorId(veiculoRequest.Id.Value);
                    var veiculoNovo = new Veiculo(veiculoRequest.Placa, veiculoRequest.Modelo, veiculoRequest.Id.Value);
                    _repositoryVeiculo.Adicionar(veiculoNovo);
                    return true;
                }

            }
            catch (System.Exception)
            {
                AddNotification("AdicionarOuAlterar","Erro ao atualizar Veiculo. Tente novamente.");
                return false;
            }
        }

        public List<VeiculoResponse> ListarVeiculo(string placa)
        {
            try
            {
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
            catch (System.Exception)
            {

                AddNotification("Lista", "Erro ao listar Veiculo, tente novamente");
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