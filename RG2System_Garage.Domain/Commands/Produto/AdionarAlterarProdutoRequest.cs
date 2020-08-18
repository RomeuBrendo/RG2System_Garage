namespace RG2System_Garage.Domain.Commands.Produto
{
    public class AdionarAlterarProdutoRequest
    {
        public int? Id { get; set; }
        public string Descricao { get;  set; }
        public int Estoque { get;  set; }
    }
}
