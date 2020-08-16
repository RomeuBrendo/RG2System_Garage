using prmToolkit.NotificationPattern;

namespace RG2System_Garage.Domain.Entities.Base
{
    public class EntityBase : Notifiable
    {
        public int Id { get; set; }
    }
}
