﻿using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Entities
{
    public class Orcamento : EntityBase
    {
        protected Orcamento()
        {

        }
        public Orcamento(OrcamentoRequest request, Cliente cliente)
        {
            this.ClearNotifications();
            Cliente = cliente;
            FormaPagamento = request.FormaPagamento;
            ValorTotal = request.ValorTotal;
            ValorDesconto = request.ValorDesconto;
            ValorAcrescimo = request.ValorAcrescimo;
            Observacao = request.Observacao;
            ExisteOrdemServico = request.ExisteOrdemServico;
            DataCriacao = request.DataCriacao;

            if (Cliente == null)
                AddNotification("Cliente", MSG.X0_INVALIDO.ToFormat("Cliente"));
            
            PopulaItens(request.Itens);

            ValidaCampos();
        }

        void ValidaCampos()
        {
            if (Itens == null)
                AddNotification("Itens", MSG.X0_INVALIDO.ToFormat("Itens"));

            new AddNotifications<Orcamento>(this)
                .IfNullOrEmpty(x => x.FormaPagamento, MSG.X0_INVALIDA.ToFormat("Forma Pagamento"))
                .IfNotDate(x => x.DataCriacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data Criação"));

            if (ValorTotal == 0)
            {
                AddNotification("ValorTotal", MSG.X0_INVALIDO.ToFormat("Valor Total"));
            }
        }

        public void Alterar(OrcamentoRequest request)
        {
            this.ClearNotifications();
            FormaPagamento = request.FormaPagamento;
            ValorTotal = request.ValorTotal;
            ValorDesconto = request.ValorDesconto;
            ValorAcrescimo = request.ValorAcrescimo;
            Observacao = request.Observacao;
            DataCriacao = request.DataCriacao;

            PopulaItens(request.Itens);

            ValidaCampos();
        }

        void PopulaItens(List<OrcamentoItensRequest> request)
        {
            var itensNovos = new List<OrcamentoItem>();

            foreach (var item in request)
            {
                var itemNovo = new OrcamentoItem(item.OrcamentoId, item.ProdutoServicoId, item.PrecoVenda);
                AddNotifications(itemNovo);

                itensNovos.Add(itemNovo);
            }

            if (itensNovos != null)
                Itens = itensNovos;
        }
        public Cliente Cliente { get; private set; }
        public Int64 Numero { get; set; }
        public string FormaPagamento { get; private set; } // Futuramente terá um cadastro exclusivo para forma de pagamento.
        public double ValorTotal { get; private set; }
        public double ValorDesconto { get; private set; }
        public double ValorAcrescimo { get; private set; }
        public string Observacao { get; private set; }
        public bool ExisteOrdemServico { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public List<OrcamentoItem> Itens { get; private set; }
    }
}
