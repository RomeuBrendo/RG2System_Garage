using prmToolkit.NotificationPattern;

namespace RG2System_Garage.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        protected Nome()
        {

        }
        public Nome(string razaoSocial, string nomeFantasia)
        {
            this.ClearNotifications();
            RazaoSocial = razaoSocial;
            Fantasia = nomeFantasia;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.RazaoSocial, 1, 500)
                .IfNullOrInvalidLength(x => x.Fantasia, 1, 500);
        }

        public string RazaoSocial { get; private set; }
        public string Fantasia { get; private set; }
    }
}
