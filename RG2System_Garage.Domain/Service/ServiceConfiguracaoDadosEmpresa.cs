using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Configuracao;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using RG2System_Garage.Domain.ValueObjects;
using System;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceConfiguracaoDadosEmpresa : Notifiable, IServiceConfiguracaoDadosEmpresa
    {
        private readonly IRepositoryConfiguracaoDadosEmpresa _repositoryConfiguracaoDadosEmpresa;

        public ServiceConfiguracaoDadosEmpresa(IRepositoryConfiguracaoDadosEmpresa repositoryConfiguracaoDadosEmpresa)
        {
            _repositoryConfiguracaoDadosEmpresa = repositoryConfiguracaoDadosEmpresa;
        }

        public void AdicionarAlterar(DadosEmpresaRequest request)
        {
            try
            {
                this.ClearNotifications();
                if (request == null)
                {
                    AddNotification("Resquest", MSG.X0_INVALIDO.ToFormat("Request"));
                }

                var nome = new Nome(request.RazaoSocial, request.NomeFantasia);
                var telefone = new Telefone(request.Fixo, request.Celular);
                var email = new Email(request.Email);

                if ((request.Id != null) && (request.Id != Guid.Empty)) //Alteração
                {
                    var dadosEmpresa = _repositoryConfiguracaoDadosEmpresa.ObterPorId(request.Id.Value);

                    if (dadosEmpresa == null)
                    {
                        AddNotification("DadosEmpresa", MSG.DADOS_NAO_ENCONTRADOS);
                        return;
                    }

                    dadosEmpresa.AlterarConfiguracaoDadosEmpresa(request.Id.Value, nome, telefone, request.Endereco, email);

                    if (IsInvalid()) return;

                    _repositoryConfiguracaoDadosEmpresa.Editar(dadosEmpresa);
                    return;
                }

                var dadosEmpresaNovo = new ConfiguracaoDadosEmpresa(nome, telefone, request.Endereco, email);

                if (IsInvalid()) return;

                _repositoryConfiguracaoDadosEmpresa.Adicionar(dadosEmpresaNovo);
            }
            catch 
            {
                MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Inserção/Alteração");
                return;
            }
            
        }

        public DadosEmpresaResponse ObterDadosEmpresa()
        {
            try
            {
                var response = _repositoryConfiguracaoDadosEmpresa.Listar().FirstOrDefault();

                if (response == null)
                    return null;

                return (DadosEmpresaResponse)response;
            }
            catch
            {

                MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Consulta dados Empresa");
                return null;
            }
        }
    }
}
