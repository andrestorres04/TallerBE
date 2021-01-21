using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Core.DTO
{
    public class VentaDTO
    {
        public string NumBastidor { get; set; }
        public int? CodVentas { get; set; }
        public int? CodCliente { get; set; }
        public int? CodConce { get; set; }
        public string TipoVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Combustible { get; set; }
        public string Precio { get; set; }
        public string Ano { get; set; }

        public VentaDTO()
        {

        }
    }
}
