using Impuestos.DAL.Data;
using Impuestos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impuestos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesFiscalesController : ControllerBase
    {
        private readonly DataContext _context;

        public ComprobantesFiscalesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ComprobantesFiscales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComprobantesFiscale>>> GetComprobantesFiscales()
        {
            var comprobantes = await _context.ComprobantesFiscales
                .Select(c => new ComprobantesFiscale
                {
                    Id = c.Id,
                    RncCedula = c.RncCedula,
                    Ncf = c.Ncf,
                    Monto = c.Monto,
                    Itbis18 = (decimal)(c.Itbis18 != null ? c.Itbis18 : 0) 
                })
                .ToListAsync();

            
            if (comprobantes == null || comprobantes.Count == 0)
            {
                return NotFound("No se encontraron comprobantes fiscales.");
            }

            // Calcular la suma total del monto (incluido el ITBIS)
            decimal totalMonto = (decimal)comprobantes.Sum(c => c.Monto + c.Itbis18);

            // Calcular la suma total del ITBIS
            decimal totalITBIS = (decimal)comprobantes.Sum(c => c.Itbis18);

            var response = new
            {
                Comprobantes = comprobantes,
                TotalMonto = totalMonto,
                TotalITBIS = totalITBIS
            };

            return Ok(response);
        }

        // GET: api/ComprobantesFiscales/{rncCedula}
        [HttpGet("{rncCedula}")]
        public async Task<ActionResult<IEnumerable<ComprobantesFiscale>>> GetComprobantesFiscalesByRncCedula(string rncCedula)
        {
            var comprobantes = await _context.ComprobantesFiscales
                .Where(c => c.RncCedula == rncCedula)
                .Select(c => new ComprobantesFiscale
                {
                    Id = c.Id,
                    RncCedula = c.RncCedula,
                    Ncf = c.Ncf,
                    Monto = c.Monto,
                    Itbis18 = (decimal)(c.Itbis18 != null ? c.Itbis18 : 0) 
                })
                .ToListAsync();

            if (comprobantes == null || comprobantes.Count == 0)
            {
                return NotFound("No se encontraron comprobantes fiscales para esta persona.");
            }

            // Calcular la suma total del monto (incluido el ITBIS)
            decimal totalMonto = (decimal)comprobantes.Sum(c => c.Monto + c.Itbis18);

            // Calcular la suma total del ITBIS
            decimal totalITBIS = (decimal)comprobantes.Sum(c => c.Itbis18);

            
            var response = new
            {
                Comprobantes = comprobantes,
                TotalMonto = totalMonto,
                TotalITBIS = totalITBIS
            };

            return Ok(response);
        }

        // GET: api/ComprobantesFiscales/Contribuyentes
        [HttpGet("Contribuyentes")]
        public async Task<ActionResult<IEnumerable<Contribuyente>>> GetContribuyentes()
        {
            var contribuyentes = await _context.Contribuyentes.ToListAsync();

            if (contribuyentes == null || contribuyentes.Count == 0)
            {
                return NotFound("No se encontraron contribuyentes.");
            }

            return Ok(contribuyentes);
        }
    }
}
