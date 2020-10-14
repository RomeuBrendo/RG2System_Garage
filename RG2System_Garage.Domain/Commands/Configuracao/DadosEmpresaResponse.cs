using RG2System_Garage.Domain.Entities;
using System;

namespace RG2System_Garage.Domain.Commands.Configuracao
{
    public class DadosEmpresaResponse
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public static explicit operator DadosEmpresaResponse(ConfiguracaoDadosEmpresa v)
        {
            return new DadosEmpresaResponse()
            {
                Id = v.Id,
                NomeFantasia = v.Nome.Fantasia,
                RazaoSocial = v.Nome.RazaoSocial,
                Celular = v.Telefone.Celular,
                Fixo = v.Telefone.Fixo,
                Endereco = v.Endereco,
                Email = v.Email.Endereco
            };
        }
    }
}
