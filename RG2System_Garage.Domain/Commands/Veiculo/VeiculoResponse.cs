using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG2System_Garage.Domain.Commands.Veiculo
{
    public class VeiculoResponse
    {
        public int? Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
    }
}
