namespace RG2System_Garage.Domain.Commands.Orcamento
{
    public class ProdutosOrcamentoResponse
    {
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
