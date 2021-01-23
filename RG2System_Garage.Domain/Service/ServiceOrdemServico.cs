using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceOrdemServico : Notifiable, IServiceOrdemServico
    {
        private readonly IRepositoryFormaPagamento _repositoryFormaPagamento;
        private readonly IRepositoryOrdemServico _repositoryOrdemServico;

        public ServiceOrdemServico(IRepositoryFormaPagamento repositoryFormaPagamento, IRepositoryOrdemServico repositoryOrdemServico)
        {
            _repositoryFormaPagamento = repositoryFormaPagamento;
            _repositoryOrdemServico = repositoryOrdemServico;
        }

        public void AdicionarAlterar(OrdemServicoRequest request)
        {
            try
            {
                this.ClearNotifications();

                if (request == null)
                {
                    AddNotification("Request", "Request inválido");
                    return;
                }

                if ((request.Id.Value != Guid.Empty) && (request.Id.Value != null)) //Alteração
                {
                    var or = _repositoryOrdemServico.ObterPorId(request.Id.Value);
                }
            }
            catch (Exception ex)
            {
                AddNotification("AdicionarAlterar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AdicionarAlterar ") + ex);
                return;

            }
        }
    }
}
