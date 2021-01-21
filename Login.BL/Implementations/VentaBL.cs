using Login.BL.Contracts;
using Login.Core.DTO;
using Login.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.BL.Implementations
{
    public class VentaBL : IVentaBL
    {
        public IVentaRepository _ventaRepository { get; set; }
        public VentaBL(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }
        public IEnumerable<VentaDTO> Get()
        {
            var listaVentas = _ventaRepository.Get();
            return listaVentas;
        }
    }
}
