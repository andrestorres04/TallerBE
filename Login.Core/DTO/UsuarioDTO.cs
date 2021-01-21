using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Core.DTO
{
    public class UsuarioDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int CodEmpleado { get; set; }
        public int CodConce { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string TipoEmpleado { get; set; }
        public UsuarioDTO()
        {
        }
    }
}
