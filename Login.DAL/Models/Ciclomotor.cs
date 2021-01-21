using System;
using System.Collections.Generic;

namespace Login.DAL.Models
{
    public partial class Ciclomotor
    {
        public string MatCiclo { get; set; }
        public string NumBastidor { get; set; }

        public virtual Vehiculo NumBastidorNavigation { get; set; }
    }
}
