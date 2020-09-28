using System;

namespace RG2System_Garage.Domain.Commands.Produto
{
    public class AdionarAlterarProdutoRequest
    {
        public Guid? Id { get; set; }
        public string Descricao { get;  set; }
        public int Estoque { get;  set; }
        public float PrecoCusto { get; set; }
        public float PrecoVenda { get; set; }
    }
}
