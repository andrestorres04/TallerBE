using Login.BL.Contracts;
using Login.Core.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController
    {
       
        public IUsuarioBL _usuarioBL { get; set; }
        public UsuarioController(IUsuarioBL usuarioBL)
        {
            _usuarioBL = usuarioBL;
        }

        [HttpPost]
        public void Add(UsuarioDTO usuarioDTO)
        {
            _usuarioBL.Add(usuarioDTO);
        }

        public void Get()
        {
            _usuarioBL.Get();
        }

    }
}
