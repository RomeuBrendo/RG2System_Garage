using RG2System_Garage.Domain.Enum;
using System;

namespace RG2System_Garage.Domain.Commands.FormaPagamento
{
    public class FormaPagamentoResponse
    {
        public Guid? Id { get; set; }
        public string Descricao { get; set; }
        public EnumFormaPgtTipo Tipo { get; set; }
        public int PrazoRecebimento { get; set; }
        public int QuantidadeParcela { get; set; }

        public static explicit operator FormaPagamentoResponse(Entities.FormaPagamento v)
        {
            return new FormaPagamentoResponse()
            {
                Id = v.Id,
                Descricao = v.Descricao,
                Tipo = v.Tipo,
                PrazoRecebimento = v.PrazoRecebimento,
                QuantidadeParcela = v.QuantidadeParcela
            };
        }
    }
}
