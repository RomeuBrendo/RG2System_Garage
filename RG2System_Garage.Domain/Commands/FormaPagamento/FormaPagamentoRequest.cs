using RG2System_Garage.Domain.Enum;
using System;

namespace RG2System_Garage.Domain.Commands.FormaPagamento
{
    public class FormaPagamentoRequest
    {
        public Guid ? Id  { get; set; }
        public string Descricao { get; set; }
        public EnumFormaPgtTipo Tipo { get; set; }
        public int PrazoRecebimento { get; set; }
        public int QuantidadeParcela { get; set; }
    }
}
