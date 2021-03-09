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
    [Route("api/ClientCommands")]
    [ApiController]
    public class ClientCommandsApiController : ControllerBase
    {
        private readonly NegosudContext _context;

        public ClientCommandsApiController(NegosudContext context)
        {
            _context = context;
        }

        // GET: api/ClientCommands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientCommand>>> GetClientCommands()
        {
            return await _context.ClientCommands.ToListAsync();
        }

        // GET: api/ClientCommands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientCommand>> GetClientCommand(int id)
        {
            var clientCommand = await _context.ClientCommands.FindAsync(id);

            if (clientCommand == null)
            {
                return NotFound();
            }

            return clientCommand;
        }

        // PUT: api/ClientCommands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientCommand(int id, ClientCommand clientCommand)
        {
            if (id != clientCommand.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientCommand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientCommandExists(id))
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

        // POST: api/ClientCommands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientCommand>> PostClientCommand(ClientCommand clientCommand)
        {
            _context.ClientCommands.Add(clientCommand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientCommand", new { id = clientCommand.Id }, clientCommand);
        }

        // DELETE: api/ClientCommands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientCommand(int id)
        {
            var clientCommand = await _context.ClientCommands.FindAsync(id);
            if (clientCommand == null)
            {
                return NotFound();
            }

            _context.ClientCommands.Remove(clientCommand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientCommandExists(int id)
        {
            return _context.ClientCommands.Any(e => e.Id == id);
        }
    }
}
