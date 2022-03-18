using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend_Facturacion.Data;
using Backend_Facturacion.Models;

namespace Backend_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Detalle_VentasController : ControllerBase
    {
        private readonly Backend_FacturacionContext _context;

        public Detalle_VentasController(Backend_FacturacionContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_Ventas>>> GetDetalle_Ventas()
        {
            return await _context.Detalle_Ventas.ToListAsync();
        }

        // GET: api/Detalle_Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_Ventas>> GetDetalle_Ventas(int id)
        {
            var detalle_Ventas = await _context.Detalle_Ventas.FindAsync(id);

            if (detalle_Ventas == null)
            {
                return NotFound();
            }

            return detalle_Ventas;
        }

        // PUT: api/Detalle_Ventas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_Ventas(int id, Detalle_Ventas detalle_Ventas)
        {
            if (id != detalle_Ventas.Id_Detalle)
            {
                return BadRequest();
            }

            _context.Entry(detalle_Ventas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_VentasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Detalle_Ventas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_Ventas>> PostDetalle_Ventas(Detalle_Ventas detalle_Ventas)
        {
            _context.Detalle_Ventas.Add(detalle_Ventas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_Ventas", new { id = detalle_Ventas.Id_Detalle }, detalle_Ventas);
        }

        // DELETE: api/Detalle_Ventas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_Ventas(int id)
        {
            var detalle_Ventas = await _context.Detalle_Ventas.FindAsync(id);
            if (detalle_Ventas == null)
            {
                return NotFound();
            }

            _context.Detalle_Ventas.Remove(detalle_Ventas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_VentasExists(int id)
        {
            return _context.Detalle_Ventas.Any(e => e.Id_Detalle == id);
        }
    }
}
