using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Veiculo;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Entities
{
    public  class Veiculo : EntityBase
    {
        protected Veiculo()
        {

        }
        public Veiculo(string placa, string modelo, DateTime ano)
        {
            this.ClearNotifications();
            Placa = placa;
            Modelo = modelo;
            Ano = ano;

            new AddNotifications<Veiculo>(this)
                .IfNullOrEmpty(x => x.Placa, MSG.X0_E_OBRIGATORIA.ToFormat("Placa"))
                .IfNullOrEmpty(x => x.Modelo, MSG.X0_E_OBRIGATORIO.ToFormat("Modelo"));
        }

        public void AlterarVeiculo(VeiculoRequest novo)
        {
            this.ClearNotifications();
            Id = novo.Id.Value;
            Placa = novo.Placa;
            Modelo = novo.Modelo;
            Ano = novo.Ano;

            new AddNotifications<Veiculo>(this)
                .IfNullOrEmpty(x => x.Placa, "Campo Placa não pode ser vazio")
                .IfNullOrEmpty(x => x.Modelo, "Campo Modelo não pode ser vazio");
        }

        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public DateTime Ano { get; private set; }

    }
}
