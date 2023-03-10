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
    public class EmpleadoresController : ControllerBase
    {
        private readonly ApiBancoEmpleoDbContext _context;

        public EmpleadoresController(ApiBancoEmpleoDbContext context)
        {
            _context = context;
        }

        // GET: api/Empleadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleador>>> GetEmpleadores()
        {
            return await _context.Empleadores.ToListAsync();
        }

        // GET: api/Empleadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleador>> GetEmpleador(int id)
        {
            var empleador = await _context.Empleadores.FindAsync(id);

            if (empleador == null)
            {
                return NotFound();
            }

            return empleador;
        }

        // PUT: api/Empleadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleador(int id, Empleador empleador)
        {
            if (id != empleador.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadorExists(id))
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

        // POST: api/Empleadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empleador>> PostEmpleador(Empleador empleador)
        {
            _context.Empleadores.Add(empleador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleador", new { id = empleador.Id }, empleador);
        }

        // DELETE: api/Empleadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleador(int id)
        {
            var empleador = await _context.Empleadores.FindAsync(id);
            if (empleador == null)
            {
                return NotFound();
            }

            _context.Empleadores.Remove(empleador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadorExists(int id)
        {
            return _context.Empleadores.Any(e => e.Id == id);
        }
    }
}
