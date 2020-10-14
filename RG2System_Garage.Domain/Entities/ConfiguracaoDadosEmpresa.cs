using RG2System_Garage.Domain.Entities.Base;
using RG2System_Garage.Domain.ValueObjects;
using System;

namespace RG2System_Garage.Domain.Entities
{
    public class ConfiguracaoDadosEmpresa : EntityBase
    {
        protected ConfiguracaoDadosEmpresa()
        {

        }
        public ConfiguracaoDadosEmpresa(Nome nome, Telefone telefone, string endereco, Email email)
        {
            CarregaPropriedades(nome, telefone, endereco, email);
        }

        public void AlterarConfiguracaoDadosEmpresa(Guid id, Nome nome, Telefone telefone, string endereco, Email email)
        {
            Id = id;
            CarregaPropriedades(nome, telefone, endereco, email);
        }
        private void CarregaPropriedades(Nome nome, Telefone telefone, string endereco, Email email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }
        public Nome Nome { get; private set; }
        public Telefone Telefone { get; private set; }
        public string Endereco { get; private set; }
        public Email Email { get; private set; }
    }
}
