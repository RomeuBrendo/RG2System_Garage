using System;

namespace RG2System_Garage.Domain.Commands.Produto
{
    public class AdionarAlterarProdutoRequest
    {
        public Guid? Id { get; set; }
        public string Descricao { get;  set; }
        public string Estoque { get;  set; }
        public string PrecoCusto { get; set; }
        public string PrecoVenda { get; set; }
    }
}
