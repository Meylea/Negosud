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
    [Route("api/SupplierCommandLines")]
    [ApiController]
    public class SupplierCommandLinesApiController : ControllerBase
    {
        private readonly NegosudContext _context;

        public SupplierCommandLinesApiController(NegosudContext context)
        {
            _context = context;
        }

        // GET: api/SupplierCommandLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierCommandLine>>> GetSupplierCommandLines()
        {
            return await _context.SupplierCommandLines.ToListAsync();
        }

        // GET: api/SupplierCommandLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierCommandLine>> GetSupplierCommandLine(int id)
        {
            var supplierCommandLine = await _context.SupplierCommandLines.FindAsync(id);

            if (supplierCommandLine == null)
            {
                return NotFound();
            }

            return supplierCommandLine;
        }

        // PUT: api/SupplierCommandLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierCommandLine(int id, SupplierCommandLine supplierCommandLine)
        {
            if (id != supplierCommandLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierCommandLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierCommandLineExists(id))
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

        // POST: api/SupplierCommandLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierCommandLine>> PostSupplierCommandLine(SupplierCommandLine supplierCommandLine)
        {
            _context.SupplierCommandLines.Add(supplierCommandLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierCommandLine", new { id = supplierCommandLine.Id }, supplierCommandLine);
        }

        // DELETE: api/SupplierCommandLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierCommandLine(int id)
        {
            var supplierCommandLine = await _context.SupplierCommandLines.FindAsync(id);
            if (supplierCommandLine == null)
            {
                return NotFound();
            }

            _context.SupplierCommandLines.Remove(supplierCommandLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierCommandLineExists(int id)
        {
            return _context.SupplierCommandLines.Any(e => e.Id == id);
        }
    }
}
