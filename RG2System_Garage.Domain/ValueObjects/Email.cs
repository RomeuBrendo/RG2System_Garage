using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Resources;

namespace RG2System_Garage.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }
        public Email(string endereco)
        {
            this.ClearNotifications();
            Endereco = endereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.Endereco, MSG.X0_INVALIDO.ToFormat("Email"));
        }

        public string Endereco { get; private set; }
    }
}
