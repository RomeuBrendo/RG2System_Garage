﻿using System;

namespace RG2System_Garage.Domain.Commands.Produto
{
    public class ProdutoResponse
    {
        public Guid Id { get; set; }
        public string Descricao { get;  set; }
        public int Estoque { get;  set; }
    }
}
