using System;

namespace RG2System_Garage.Domain.Commands.Cliente
{
    public class ClienteResponse
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        public static explicit operator ClienteResponse(Entities.Cliente v)
        {
            return new ClienteResponse()
            {
                Id = v.Id,
                Nome = v.Nome,
                CPFCNPJ = v.CPFCNPJ,
                Telefone1 = v.Telefone1,
                Telefone2 = v.Telefone2
            };
        }
    }
}
