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
    public class VentaController : ControllerBase
    {
        public IVentaBL _ventaBL { get; set; }
        public VentaController(IVentaBL ventaBL)
        {
            _ventaBL = ventaBL;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VentaDTO>> Get()
        {
            return Ok(_ventaBL.Get());
        }


    }
}
