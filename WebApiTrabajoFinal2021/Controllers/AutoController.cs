using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrabajoFinal2021.Models;

namespace WebApiTrabajoFinal2021.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly DBAutoContext _context;
        public AutoController(DBAutoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return _context.Autos.ToList();
        }

        [HttpPost]
        public ActionResult Post(Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerVehiculo", new { Id = auto.Id }, auto);
        }
        [HttpDelete("{Id}")]
        public ActionResult<Auto> Delete(string Id)
        {

            var auto = _context.Autos.Find(Id);

            if (auto == null)
            {
                return NotFound();
            }
            _context.Autos.Remove(auto);
            _context.SaveChanges();

            return auto;
        } 

        [HttpGet("ObtenerVehiculo/{Id}", Name = "ObtenerVehiculo")]
        public ActionResult<Auto> ObtenerVehiculo(int Id)
        {
            return _context.Autos.Find(Id);
        }
        [HttpGet("ObtenerVehiculoPorMarca/{Marca}", Name = "ObtenerVehiculoPorMarca")]
        public ActionResult<Auto> ObtenerVehiculoPorMarca(string Marca)
        {
            return _context.Autos.Find(Marca);
        }
        [HttpGet("ObtenerVehiculoPorColor/{Color}", Name = "ObtenerVehiculoPorColor")]
        public ActionResult<Auto> ObtenerCustomer(string Color)
        {
            return _context.Autos.Find(Color);
        }
        [HttpGet("modeloymarca/{modelo}/{marca}", Name = "ObtenerVehiculoPorModeloYMarca")]
      
        public IEnumerable<Auto> ObtenerVehiculoPorModeloYMarca(string modelo, string marca)
        {
            var autos = (from a in _context.Autos where a.Modelo.Contains(modelo) && a.Marca.Contains(marca) select a).ToList();
            return autos;
        }


    }
}