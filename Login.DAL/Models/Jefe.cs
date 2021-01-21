using System;
using System.Collections.Generic;

namespace Login.DAL.Models
{
    public partial class Jefe
    {
        public int CodJefe { get; set; }
        public int CodEmpleado { get; set; }

        public virtual Empleado CodEmpleadoNavigation { get; set; }
    }
}
