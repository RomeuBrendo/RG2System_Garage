using RG2System_Garage.Domain.Enum;
using System;

namespace RG2System_Garage.Domain.Commands.Produto
{
    public class AdionarAlterarProdutoServicoRequest
    {
        public Guid? Id { get; set; }
        public string Descricao { get;  set; }
        public string Estoque { get;  set; }
        public string PrecoCusto { get; set; }
        public string PrecoVenda { get; set; }
        public EnumTipo Tipo { get; set; }
        public string Observacao { get; set; }
        public EnumSituacao Situacao { get; set; }
    }
}
