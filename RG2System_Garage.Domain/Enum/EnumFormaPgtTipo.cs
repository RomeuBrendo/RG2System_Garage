using System.ComponentModel;

namespace RG2System_Garage.Domain.Enum
{
    public enum EnumFormaPgtTipo
    {
        Dinheiro = 0,

        [Description("Cartão Débito")]
        CartaoDebito = 1,

        [Description("Cartão Crédito")]
        CartaoCredito = 2,

        [Description("Deposito Bancário")]
        DepositoBancario = 3,

        [Description("Dinheiro a Prazo")]
        DinheiroPrazo = 4,

        [Description("Outros")]
        Outros = 5

    }
}
