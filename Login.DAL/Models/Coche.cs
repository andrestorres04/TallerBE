using System;
using System.Collections.Generic;

namespace Login.DAL.Models
{
    public partial class Coche
    {
        public string MatCoche { get; set; }
        public string NumBastidor { get; set; }

        public virtual Vehiculo NumBastidorNavigation { get; set; }
    }
}
