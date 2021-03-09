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
    [Route("api/SupplierCommands")]
    [ApiController]
    public class SupplierCommandsApiController : ControllerBase
    {
        private readonly NegosudContext _context;

        public SupplierCommandsApiController(NegosudContext context)
        {
            _context = context;
        }

        // GET: api/SupplierCommands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierCommand>>> GetSupplierCommands()
        {
            return await _context.SupplierCommands.ToListAsync();
        }

        // GET: api/SupplierCommands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierCommand>> GetSupplierCommand(int id)
        {
            var supplierCommand = await _context.SupplierCommands.FindAsync(id);

            if (supplierCommand == null)
            {
                return NotFound();
            }

            return supplierCommand;
        }

        // PUT: api/SupplierCommands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierCommand(int id, SupplierCommand supplierCommand)
        {
            if (id != supplierCommand.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierCommand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierCommandExists(id))
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

        // POST: api/SupplierCommands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierCommand>> PostSupplierCommand(SupplierCommand supplierCommand)
        {
            _context.SupplierCommands.Add(supplierCommand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierCommand", new { id = supplierCommand.Id }, supplierCommand);
        }

        // DELETE: api/SupplierCommands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierCommand(int id)
        {
            var supplierCommand = await _context.SupplierCommands.FindAsync(id);
            if (supplierCommand == null)
            {
                return NotFound();
            }

            _context.SupplierCommands.Remove(supplierCommand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierCommandExists(int id)
        {
            return _context.SupplierCommands.Any(e => e.Id == id);
        }
    }
}
