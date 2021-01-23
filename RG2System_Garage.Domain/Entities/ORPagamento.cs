using RG2System_Garage.Domain.Entities.Base;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class ORPagamento : EntityBase 
    {
        public ORPagamento(ORPagamento formaPagamentoId, OrdemServico ordemServico, float valor)
        {
            FormaPagamento = formaPagamentoId;
            OrdemServico = ordemServico;
            Valor = valor;
        }

        public ORPagamento FormaPagamento { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public float Valor { get; private set; }
    }
}
