using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(string descricao, int estoque)
        {
            Descricao = descricao;
            Estoque = estoque;

            new AddNotifications<Produto>(this)
                .IfNullOrInvalidLength(x => x.Descricao, 2, 50, "O campo descrição deve conter entre 2 e 50 caracteres");

        }

        public Produto(string descricao, int estoque, int id)
        {
            Id = id;
            Descricao = descricao;
            Estoque = estoque;

            new AddNotifications<Produto>(this)
                 .IfNullOrInvalidLength(x => x.Descricao, 2, 50, "O campo descrição deve conter entre 2 e 50 caracteres");

            if (id < 1)
                AddNotification("Id", "Para realizar alteração, é necessario passar um ID valido");
        }

        public string Descricao { get; private set; }
        public int Estoque { get; private set; }
    }
}
