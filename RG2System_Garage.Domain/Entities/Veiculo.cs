using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Entities.Base;

namespace RG2System_Garage.Domain.Entities
{
    public  class Veiculo : EntityBase
    {
        public Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;

            new AddNotifications<Veiculo>(this)
                .IfNullOrEmpty(x => x.Placa, "Campo Placa não pode ser vazio")
                .IfNullOrEmpty(x => x.Modelo, "Campo Modelo não pode ser vazio");
        }

        public string Placa { get; private set; }
        public string Modelo { get; private set; }
    }
}
