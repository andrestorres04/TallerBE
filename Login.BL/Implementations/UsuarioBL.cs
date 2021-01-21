using Login.BL.Contracts;
using Login.Core.DTO;
using Login.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepository _usuarioRepository { get; set; }
        public UsuarioBL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public bool Login(UsuarioDTO usuarioDTO)
        {
           return _usuarioRepository.Login(usuarioDTO);
        }

        public void Add(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.Add(usuarioDTO);
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            var listaUsuarios = _usuarioRepository.Get();
            return listaUsuarios;
        }

        public void Get(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }

    }
}
