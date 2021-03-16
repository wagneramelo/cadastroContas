
using BancoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace BancoAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ContasController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/Contas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conta>>> GetContas()
        {
            return await _context.Contas.ToListAsync();
        }
        // GET: api/Contas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> GetConta(int id)
        {
            var conta = await _context.Contas.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }
            return conta;
        }
        // PUT: api/Contas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConta(int id, Conta conta)
        {
            if (id != conta.ContaId)
            {
                return BadRequest();
            }
            _context.Entry(conta).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContasExists(id))
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
        // POST: api/Contas
        [HttpPost]
        public async Task<ActionResult<Conta>> PostConta(Conta conta)
        {
            _context.Contas.Add(conta);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetContas", new { id = conta.ContaId }, conta);
        }
        // DELETE: api/Contas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Conta>> DeleteConta(int id)
        {
            var conta = await _context.Contas.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }
            _context.Contas.Remove(conta);
            await _context.SaveChangesAsync();
            return conta;
        }
        private bool ContasExists(int id)
        {
            return _context.Contas.Any(e => e.ContaId == id);
        }
    }
}