using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Resources;

namespace RG2System_Garage.Domain.ValueObjects
{
    public class Telefone : Notifiable
    {
        public Telefone(string fixo, string celular)
        {
            this.ClearNotifications();
            Fixo = fixo;
            Celular = celular;
            ValidaCampos();
        }
        protected Telefone()
        {

        }
        public string Fixo { get; private set; }
        public string Celular { get; private set; }

        private void ValidaCampos()
        {
            new AddNotifications<Telefone>(this)
                .IfLengthGreaterThan(x => x.Celular, 15, MSG.X0_INVALIDO.ToFormat("Celular"))
                .IfLengthGreaterThan(x => x.Fixo, 15, MSG.X0_INVALIDO.ToFormat("Fixo"));
        }
    }
}
