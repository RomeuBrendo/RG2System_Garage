﻿using RG2System_Garage.Domain.Commands.Veiculo;
using System;
using System.Collections.Generic;

namespace RG2System_Garage.Domain.Commands.Cliente
{
    public class ClienteRequest
    {
        public Guid? Id { get; set; }
        public string Nome { get;  set; }
        public string CPFCNPJ { get;  set; }
        public string Telefone1 { get;  set; }
        public string Telefone2 { get;  set; }
        public List<VeiculoRequest> Veiculos { get; set; }

    }
}
