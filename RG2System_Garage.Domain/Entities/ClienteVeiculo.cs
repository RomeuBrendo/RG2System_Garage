using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Commands.Veiculo;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;

namespace RG2System_Garage.Domain.Entities
{
    public class ClienteVeiculo : EntityBase
    {
        protected ClienteVeiculo()
        {

        }

        public ClienteVeiculo(Cliente cliente, Veiculo veiculo)
        {
            Cliente = cliente;
            Veiculo = veiculo;

            if (Cliente == null)
                AddNotification("Cliente", MSG.X0_E_OBRIGATORIO.ToFormat("Cliente"));

            if (Veiculo == null)
                AddNotification("Veiculos", MSG.X0_E_OBRIGATORIO.ToFormat("Veiculos"));

        }

        public Cliente Cliente { get; private set; }
        public Veiculo Veiculo { get; private set; }
    }
}
