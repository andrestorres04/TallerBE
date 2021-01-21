using System;
using System.Collections.Generic;

namespace Login.DAL.Models
{
    public partial class Propuesta
    {
        public int CodPropuesta { get; set; }
        public int CodCliente { get; set; }
        public int CodVentas { get; set; }
        public string NumBastidor { get; set; }
        public DateTime? FechaValidez { get; set; }
        public string Precio { get; set; }

        public virtual Cliente CodClienteNavigation { get; set; }
        public virtual Ventas CodVentasNavigation { get; set; }
        public virtual Vehiculo NumBastidorNavigation { get; set; }
    }
}
