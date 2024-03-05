using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Compartido.Models;
using Parcial2_AP1_AaronHernandez.API.DAL;

namespace Parcial2_AP1_AaronHernandez.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoDetalleController : ControllerBase
    {
        private readonly Contexto _context;

        public VehiculoDetalleController(Contexto context)
        {
            _context = context;
        }

        // GET: api/VehiculoDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehiculoDetalle>>> GetVehiculoDetalle()
        {
            return await _context.VehiculoDetalle.ToListAsync();
        }

        // GET: api/VehiculoDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehiculoDetalle>> GetVehiculoDetalle(int id)
        {
            var vehiculoDetalle = await _context.VehiculoDetalle.FindAsync(id);

            if (vehiculoDetalle == null)
            {
                return NotFound();
            }

            return vehiculoDetalle;
        }

        // PUT: api/VehiculoDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculoDetalle(int id, VehiculoDetalle vehiculoDetalle)
        {
            if (id != vehiculoDetalle.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehiculoDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoDetalleExists(id))
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

        // POST: api/VehiculoDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehiculoDetalle>> PostVehiculoDetalle(VehiculoDetalle vehiculoDetalle)
        {
            _context.VehiculoDetalle.Add(vehiculoDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculoDetalle", new { id = vehiculoDetalle.Id }, vehiculoDetalle);
        }

        // DELETE: api/VehiculoDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculoDetalle(int id)
        {
            var vehiculoDetalle = await _context.VehiculoDetalle.FindAsync(id);
            if (vehiculoDetalle == null)
            {
                return NotFound();
            }

            _context.VehiculoDetalle.Remove(vehiculoDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehiculoDetalleExists(int id)
        {
            return _context.VehiculoDetalle.Any(e => e.Id == id);
        }
    }
}
