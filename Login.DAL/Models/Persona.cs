using System;
using System.Collections.Generic;

namespace Login.DAL.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
