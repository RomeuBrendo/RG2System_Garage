using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RG2System_Garage.Domain.Entities
{
    public class ProdutoServico : EntityBase
    {
        protected ProdutoServico()
        {

        }
        public ProdutoServico(AdionarAlterarProdutoServicoRequest request)
        {
            this.ClearNotifications();
            ProdutoBase(request);
        }

        public ProdutoServico(List<Movimentacao> estoqueProduto)
        {
            FichaMovimentacao = estoqueProduto;
        }

        private void ProdutoBase(AdionarAlterarProdutoServicoRequest request)
        {
            Descricao = request.Descricao;
            Tipo = request.Tipo;
            Observacao = request.Observacao;

            Situacao = EnumSituacao.Ativo;

            var estoqueProdutos = new List<Movimentacao>();
            
            estoqueProdutos.Add(new Movimentacao(Id, DateTime.Now, request.PrecoCusto, request.PrecoVenda, request.Estoque));
            
            FichaMovimentacao = estoqueProdutos;
            AddNotifications(FichaMovimentacao);
            ValidaDescricao();

        }

        private void ValidaDescricao()
        {
            new AddNotifications<ProdutoServico>(this)
                .IfNullOrInvalidLength(x => x.Descricao, 2, 50, MSG.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Descrição", "2", "50"));

            new AddNotifications<ProdutoServico>(this)
                .IfLengthGreaterThan(x => x.Observacao, 2000, MSG.X0_INVALIDA.ToFormat("Observação"));

        }
        public void AlterarProduto(AdionarAlterarProdutoServicoRequest request)
        {
            this.ClearNotifications();
            Id = request.Id.Value;
            Descricao = request.Descricao;
            Observacao = request.Observacao;
            Situacao = Situacao;
            //Não posso permitir alterar um Tipo após já salvo.        
            // Tipo = request.Tipo;
            ValidaDescricao();
        }

        public void AlterarPropriedade(ProdutoServico request)
        {
            //Trecho abaixo é apenas para modificar propriedade quando não quero o historico da tabela estoque produto, e sim somente o atual que no caso é o último.
            UltimaMovimentacao = request.FichaMovimentacao.OrderByDescending(x => x.DataLancamento).FirstOrDefault();
        }

        public string Descricao { get; private set; }

        public List<Movimentacao> FichaMovimentacao { get; private set; }

        public Movimentacao UltimaMovimentacao { get; set; }

        public EnumTipo Tipo { get; private set; }

        public string Observacao { get; private set; }

        public EnumSituacao Situacao { get; private set; }

    }
}
