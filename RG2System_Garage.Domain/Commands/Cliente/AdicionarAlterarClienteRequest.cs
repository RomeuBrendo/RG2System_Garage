using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG2System_Garage.Domain.Commands.Cliente
{
    public class AdicionarAlterarClienteRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
