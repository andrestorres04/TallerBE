using Login.Core.DTO;
using Login.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.DAL.Repositories.Contracts
{
    public interface IVentaRepository
    {
        IEnumerable<VentaDTO> Get();
    }
}
