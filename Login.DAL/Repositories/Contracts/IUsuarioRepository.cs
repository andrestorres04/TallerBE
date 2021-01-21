﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Core.DTO;

namespace Login.DAL.Repositories.Contracts
{
     public interface IUsuarioRepository
    {
        bool Login(UsuarioDTO usuarioDTO);
        void Add(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}
