using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente(string nome)
        {
            Nome = nome;

            new AddNotifications<Cliente>(this)
                .IfNullOrInvalidLength(x => x.Nome, 2, 150, "Nome deve conter entre 2 e 150 caracteres.");
        }

        public Cliente(string nome, int id)
        {
            Id = id;
            Nome = nome;

            new AddNotifications<Cliente>(this)
                .IfNullOrInvalidLength(x => x.Nome, 2, 150, "Nome deve conter entre 2 e 150 caracteres.");

            if (Id < 1)
                AddNotification("Id", "Não pode ser menor que zero");
        }

        public string Nome { get; private set; }
    }
}
