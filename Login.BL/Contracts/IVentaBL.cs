using Login.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.BL.Contracts
{
    public interface IVentaBL
    {
        IEnumerable<VentaDTO> Get();
    }
}
