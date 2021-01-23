using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Resources;

namespace RG2System_Garage.Domain.Entities
{
    public class FormaPagamento : EntityBase
    {
        protected FormaPagamento()
        {

        }
        public FormaPagamento(FormaPagamentoRequest request)
        {
            this.ClearNotifications();
            Descricao = request.Descricao;
            Tipo = request.Tipo;
            PrazoRecebimento = request.PrazoRecebimento;
            QuantidadeParcela = request.QuantidadeParcela;

            ValidaCampos();
        }

        private void ValidaCampos()
        {
            new AddNotifications<FormaPagamento>(this)
                .IfLengthLowerThan(x => x.Descricao, 3, MSG.X0_E_OBRIGATORIA_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Descrição", "3", "150"))
                .IfEnumInvalid(x => x.Tipo)
                .IfLowerThan(x => x.PrazoRecebimento, 0, MSG.O_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Prazo recebimento", "0"))
                .IfLowerThan(x => x.QuantidadeParcela, 0, MSG.O_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Quantidade parcelas", "0"));
        }

        public void Alterar(FormaPagamentoRequest request)
        {
            this.ClearNotifications();
            Descricao = request.Descricao;
            Tipo = request.Tipo;
            PrazoRecebimento = request.PrazoRecebimento;
            QuantidadeParcela = request.QuantidadeParcela;

            ValidaCampos();
        }

        public string Descricao { get; private set; }
        public EnumFormaPgtTipo Tipo { get; private set; }
        public int PrazoRecebimento { get; private set; }
        public int QuantidadeParcela { get; private set; }

    }
}
