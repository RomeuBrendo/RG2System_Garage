using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Commands;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceVeiculo : Notifiable, IServiceVeiculo
    {
        private readonly IRepositoryVeiculo  _repositoryVeiculo;

        public ServiceVeiculo(IRepositoryVeiculo repositoryVeiculo)
        {
            _repositoryVeiculo = repositoryVeiculo;
        }

        public bool Adicionar(VeiculoRequest veiculoRequest)
        {
            try
            {
                var veiculo = new Veiculo(veiculoRequest.Placa, veiculoRequest.Modelo);

                AddNotifications(veiculo);
                
                if (IsValid())
                    return false;

                _repositoryVeiculo.Adicionar(veiculo);

                return true;
            }
            catch (System.Exception)
            {
                AddNotification("Adicionar","Erro ao adicionar Veiculo. Tente novamente.");
                return false;
            }
        }

        //public bool Alterar(VeiculoRequest veiculoRequest)
        //{
        //    try
        //    {
                

        //    }
        //    catch
        //    {

        //        throw;
        //    }
        //}
    }
}
