using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RG2System_Garage.Domain.Entities
{
    public class Orcamento : EntityBase
    {
        protected Orcamento()
        {

        }
        public Orcamento(OrcamentoRequest request, Cliente cliente, Veiculo veiculo)
        {
            this.ClearNotifications();
            Cliente = cliente;
            Veiculo = veiculo;

            Observacao = request.Observacao;
            ExisteOrdemServico = request.ExisteOrdemServico;
            DataCriacao = request.DataCriacao;

            if (Cliente == null)
                AddNotification("Cliente", MSG.X0_INVALIDO.ToFormat("Cliente"));

            ValidaValores(request.ValorTotal, request.ValorDesconto, request.ValorAcrescimo);
            PopulaItens(request.Itens);

            ValidaCampos();
        }

        void ValidaCampos()
        {
            //if (Itens == null)
            //    AddNotification("Itens", MSG.X0_INVALIDO.ToFormat("Itens"));

            //if (Itens.Count == 0)
            //    AddNotification("Itens", MSG.X0_E_OBRIGATORIO.ToFormat("Produto/Serviço"));

            //new AddNotifications<Orcamento>(this)
            //    //.IfNullOrEmpty(x => x.FormaPagamento, MSG.X0_INVALIDA.ToFormat("Forma Pagamento"))
            //    .IfNotDate(x => x.DataCriacao.ToString(), MSG.X0_INVALIDA.ToFormat("Data Criação"));

            if (ValorTotal == 0)
            {
                AddNotification("ValorTotal", MSG.X0_INVALIDO.ToFormat("Valor Total"));
            }
        }

        void ValidaValores(string valorTotal, string valorDesconto, string valorAcrescimo)
        {

            double number = 0;
            var culture = CultureInfo.CurrentCulture;

            if (Double.TryParse(valorTotal, out number))
                ValorTotal = number;
            else
                AddNotification("Total", MSG.O_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Valor Total", "1"));

            number = 0;
            if (Double.TryParse(valorDesconto, out number))
                ValorDesconto = number;
            else
                AddNotification("Desconto", MSG.X0_INVALIDO.ToFormat("Valor Desconto inválido"));

            number = 0;
            if (Double.TryParse(valorAcrescimo, out number))
                ValorDesconto = number;
            else
                AddNotification("Acrescimo", MSG.X0_INVALIDO.ToFormat("Valor Acréscimo inválido"));

        }

        public void Alterar(OrcamentoRequest request)
        {
            this.ClearNotifications();
            Observacao = request.Observacao;
            DataCriacao = request.DataCriacao;

            ValidaValores(request.ValorTotal, request.ValorDesconto, request.ValorAcrescimo);

            ValidaCampos();
        }

        
        void PopulaItens(List<OrcamentoItensRequest> request)
        {
            var itensNovos = new List<OrcamentoItem>();

            foreach (var item in request)
            {
                var itemNovo = new OrcamentoItem(Id, item.ProdutoServicoId, item.PrecoVenda.ToString(), item.Quantidade);
                AddNotifications(itemNovo);

                itensNovos.Add(itemNovo);
            }

            if (itensNovos != null)
                Itens = itensNovos;
        }
        public Cliente Cliente { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public Int64 Numero { get; set; }
        public double ValorTotal { get; private set; }
        public double ValorDesconto { get; private set; }
        public double ValorAcrescimo { get; private set; }
        public string Observacao { get; private set; }
        public bool ExisteOrdemServico { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public List<OrcamentoItem> Itens { get; private set; }
    }
}
