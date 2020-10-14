using System;

namespace RG2System_Garage.Domain.Commands.Configuracao
{
    public class DadosEmpresaRequest
    {
        public Guid? Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}
