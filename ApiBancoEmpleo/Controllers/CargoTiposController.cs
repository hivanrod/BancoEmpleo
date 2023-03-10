using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBancoEmpleo;
using ClassLibraryBancoEmpleo.Models;

namespace ApiBancoEmpleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoTiposController : ControllerBase
    {
        private readonly ApiBancoEmpleoDbContext _context;

        public CargoTiposController(ApiBancoEmpleoDbContext context)
        {
            _context = context;
        }

        // GET: api/CargoTipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargoTipo>>> GetEmpleoTipo()
        {
            return await _context.EmpleoTipo.ToListAsync();
        }

        // GET: api/CargoTipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CargoTipo>> GetCargoTipo(int id)
        {
            var cargoTipo = await _context.EmpleoTipo.FindAsync(id);

            if (cargoTipo == null)
            {
                return NotFound();
            }

            return cargoTipo;
        }

        // PUT: api/CargoTipos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCargoTipo(int id, CargoTipo cargoTipo)
        {
            if (id != cargoTipo.Id)
            {
                return BadRequest();
            }

            _context.Entry(cargoTipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargoTipoExists(id))
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

        // POST: api/CargoTipos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CargoTipo>> PostCargoTipo(CargoTipo cargoTipo)
        {
            _context.EmpleoTipo.Add(cargoTipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCargoTipo", new { id = cargoTipo.Id }, cargoTipo);
        }

        // DELETE: api/CargoTipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargoTipo(int id)
        {
            var cargoTipo = await _context.EmpleoTipo.FindAsync(id);
            if (cargoTipo == null)
            {
                return NotFound();
            }

            _context.EmpleoTipo.Remove(cargoTipo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CargoTipoExists(int id)
        {
            return _context.EmpleoTipo.Any(e => e.Id == id);
        }
    }
}
