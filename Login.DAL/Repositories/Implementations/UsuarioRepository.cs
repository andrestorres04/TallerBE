using Login.DAL.Repositories.Contracts;
using Login.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.DAL.Models;

namespace Login.DAL.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public tallerContext _context { get; set; }
        public UsuarioRepository(tallerContext context)
        {
            _context = context;
        }
        public bool Login(UsuarioDTO usuarioDTO)
        {
           return _context.Empleado.Any(u => u.Usuario == "jefe" &&
                                       u.Contrasena == usuarioDTO.Password);
        }

        public void Add(UsuarioDTO usuarioDTO)
        {
            var usuario = new Empleado();
            usuario.Usuario = usuarioDTO.Username;
            usuario.Contrasena = usuarioDTO.Password;
            usuario.Dni = usuarioDTO.Dni;
            usuario.CodConce = usuarioDTO.CodConce;
            usuario.CodEmpleado = usuarioDTO.CodEmpleado;
            _context.Empleado.Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            var listaUsuarios = _context.Empleado.ToList();

            List<UsuarioDTO> listaUsuariosDTO = new List<UsuarioDTO>();

            foreach (var usuario in listaUsuarios)
            {
                var miUsuario = new UsuarioDTO
                {
                    Username = usuario.Usuario,
                    Password = usuario.Contrasena,
                    Dni = usuario.Dni,
                    CodConce = usuario.CodConce,
                    CodEmpleado = usuario.CodEmpleado,

                };

                listaUsuariosDTO.Add(miUsuario);
            }
            return listaUsuariosDTO;
        }
    }
}
