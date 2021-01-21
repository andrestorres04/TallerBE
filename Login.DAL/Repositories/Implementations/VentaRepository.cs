using Login.Core.DTO;
using Login.DAL.Models;
using Login.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.DAL.Repositories.Implementations
{
    public class VentaRepository : IVentaRepository
    {
        public tallerContext _context { get; set; }

        public VentaRepository(tallerContext context)
        {
            _context = context;
        }

        public IEnumerable<VentaDTO> Get()
        {
            var listaVehiculos = _context.Vehiculo.ToList();

            List<VentaDTO> listaVentasDTO = new List<VentaDTO>();

            foreach (var vehiculo in listaVehiculos)
            {
                var miVenta = new VentaDTO
                {
                    NumBastidor = vehiculo.NumBastidor,
                    CodVentas = vehiculo.CodVentas,
                    CodCliente = vehiculo.CodCliente,
                    CodConce = vehiculo.CodConce,
                    TipoVehiculo = vehiculo.TipoVehiculo,
                    Marca = vehiculo.Marca,
                    Modelo = vehiculo.Modelo,
                    Combustible = vehiculo.Combustible,
                    Precio = vehiculo.Precio,
                    Ano = vehiculo.Anno,


                };
                if (miVenta.CodVentas != null)
                {
                    listaVentasDTO.Add(miVenta);
                }
            }

            return listaVentasDTO;
        }
        

       
    }
}
