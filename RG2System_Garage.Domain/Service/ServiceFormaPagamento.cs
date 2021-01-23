using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Service
{
    public class ServiceFormaPagamento : Notifiable, IServiceFormaPagamento
    {
        private readonly IRepositoryFormaPagamento _repositoryFormaPagamento;

        public ServiceFormaPagamento(IRepositoryFormaPagamento repositoryFormaPagamento)
        {
            _repositoryFormaPagamento = repositoryFormaPagamento;
        }

        public void AdicionarAlterar(FormaPagamentoRequest request)
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
                    var formaPagamento = _repositoryFormaPagamento.ObterPorId(request.Id.Value);

                    formaPagamento.Alterar(request);
                    AddNotifications(formaPagamento);

                    if (IsInvalid()) return;

                    _repositoryFormaPagamento.Editar(formaPagamento);
                    return;
                }

                var formaPagamentoNova = new FormaPagamento(request);
                AddNotifications(formaPagamentoNova);

                if (IsInvalid()) return;

                _repositoryFormaPagamento.Adicionar(formaPagamentoNova);
                return;

            }
            catch (Exception ex)
            {
                AddNotification("AdicionarAlterar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("AdicionarAlterar ") + ex);
                return;
                
            }
        }

        public List<FormaPagamentoResponse> Listar(string descricao)
        {
            try
            {
                if (descricao != string.Empty)
                    return FormaPagamentoResponse(_repositoryFormaPagamento.ListarPor(x => x.Descricao.StartsWith(descricao)).ToList());
                else
                    return FormaPagamentoResponse(_repositoryFormaPagamento.Listar().ToList());
            }
            catch (Exception ex)
            {

                AddNotification("Listar", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Listar ") + ex);
                return null; 
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                this.ClearNotifications();

                var formaPagamento = _repositoryFormaPagamento.ObterPorId(id);

                _repositoryFormaPagamento.Remover(formaPagamento);
            }
            catch (Exception ex)
            {

                AddNotification("Excluir", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("Excluir ") + ex);
                return;
            }
        }

        private List<FormaPagamentoResponse> FormaPagamentoResponse(List<FormaPagamento> response)
        {
            try
            {
                if (response == null)
                    return null;

                var lista = new List<FormaPagamentoResponse>();
                foreach (var item in response)
                    lista.Add((FormaPagamentoResponse)item);

                return lista;
                
            }
            catch (Exception ex)
            {

                AddNotification("FormaPagamentoResponse", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("FormaPagamentoResponse ") + ex);
                return null;
            }
        }

        public FormaPagamentoResponse ObterPorId(Guid id)
        {
            try
            {
                return FormaPagamentoResponse(_repositoryFormaPagamento.ListarPor(X => X.Id == id).ToList()).FirstOrDefault();
            }
            catch (Exception ex)
            {

                AddNotification("ObterPorId", MSG.ERRO_AO_REALIZAR_PROCEDIMENTO_DE_X0.ToFormat("ObterPorId ") + ex);
                return null;
            }
        }
    }
}
