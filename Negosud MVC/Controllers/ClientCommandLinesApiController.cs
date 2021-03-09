using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud_MVC.Data;
using Negosud_MVC.Models;

namespace Negosud_MVC.Controllers
{
    [Route("api/ClientCommandLines")]
    [ApiController]
    public class ClientCommandLinesApiController : ControllerBase
    {
        private readonly NegosudContext _context;

        public ClientCommandLinesApiController(NegosudContext context)
        {
            _context = context;
        }

        // GET: api/ClientCommandLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientCommandLine>>> GetClientCommandLines()
        {
            return await _context.ClientCommandLines.ToListAsync();
        }

        // GET: api/ClientCommandLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientCommandLine>> GetClientCommandLine(int id)
        {
            var clientCommandLine = await _context.ClientCommandLines.FindAsync(id);

            if (clientCommandLine == null)
            {
                return NotFound();
            }

            return clientCommandLine;
        }

        // PUT: api/ClientCommandLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientCommandLine(int id, ClientCommandLine clientCommandLine)
        {
            if (id != clientCommandLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientCommandLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientCommandLineExists(id))
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

        // POST: api/ClientCommandLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientCommandLine>> PostClientCommandLine(ClientCommandLine clientCommandLine)
        {
            _context.ClientCommandLines.Add(clientCommandLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientCommandLine", new { id = clientCommandLine.Id }, clientCommandLine);
        }

        // DELETE: api/ClientCommandLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientCommandLine(int id)
        {
            var clientCommandLine = await _context.ClientCommandLines.FindAsync(id);
            if (clientCommandLine == null)
            {
                return NotFound();
            }

            _context.ClientCommandLines.Remove(clientCommandLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientCommandLineExists(int id)
        {
            return _context.ClientCommandLines.Any(e => e.Id == id);
        }
    }
}
