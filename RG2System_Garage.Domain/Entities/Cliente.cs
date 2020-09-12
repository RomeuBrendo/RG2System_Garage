﻿using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.Resources;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class Cliente : EntityBase
    {
        protected Cliente()
        {

        }
        public Cliente(ClienteRequest request)
        {
            this.ClearNotifications();
            ValidaCampos(request);
        }

        public void AlterarCliente(ClienteRequest request)
        {
            Id = request.Id.Value;

            new AddNotifications<Cliente>(this)
                .IfNotGuid(x => x.Id.ToString(), MSG.X0_INVALIDO.ToFormat("ID"));

            ValidaCampos(request);
        }

        void ValidaCampos(ClienteRequest request)
        {

            Nome = request.Nome;
            Telefone1 = request.Telefone1;
            Telefone2 = request.Telefone2;
            CPFCNPJ = request.CPFCNPJ;

            new AddNotifications<Cliente>(this)
                .IfNullOrInvalidLength(x => x.Nome, 2, 150, "Nome deve conter entre 2 e 150 caracteres.")
                .IfLengthGreaterThan(x => x.Telefone1, 15, MSG.X0_INVALIDO.ToFormat("Telefone 1"))
                .IfLengthGreaterThan(x => x.Telefone2, 15, MSG.X0_INVALIDO.ToFormat("Telefone 2"));

            ValidaCPFCNPJ(CPFCNPJ);
        }

        public string Nome { get; private set; }
        public string CPFCNPJ { get; private set; }
        public string Telefone1 { get; private set; }
        public string Telefone2 { get; private set; }

        void ValidaCPFCNPJ(string valor)
        {
            if (valor == "")
                return;

            valor.Replace("-", "");
            valor.Replace(".", "");
            valor.Replace("/", "");

            if (valor.Length == 14)
            {
                new AddNotifications<Cliente>(this)
                    .IfNotCnpj(x => x.CPFCNPJ, MSG.X0_INVALIDO.ToFormat("CNPJ"));
            }
            else
            {
                new AddNotifications<Cliente>(this)
                     .IfNotCnpj(x => x.CPFCNPJ, MSG.X0_INVALIDO.ToFormat("CPF"));
            }

        }
    }
}
