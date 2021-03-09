using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Negosud_MVC.Data;
using Negosud_MVC.Models;

namespace Negosud_MVC.Controllers
{
    public class ItemsController : Controller
    {
        private readonly NegosudContext _context;

        public ItemsController(NegosudContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index(string searchString)
        {
            var items = from m in _context.Items
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
            }


            /*var negosudContext = _context.Items.Include(i => i.Producer).Include(i => i.Supplier).Include(i => i.Type);*/
            return View(await items.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Producer)
                .Include(i => i.Supplier)
                .Include(i => i.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        //// GET: Items/Create
        //public IActionResult Create()
        //{
        //    ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name");
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "BusinessName");
        //    ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name");
        //    return View();
        //}

        //// POST: Items/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Quantity,UnitPrice,BoxPrice,Year,ProducerId,TypeId,SupplierId")] Item item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(item);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name", item.ProducerId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "BusinessName", item.SupplierId);
        //    ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", item.TypeId);
        //    return View(item);
        //}

        //// GET: Items/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var item = await _context.Items.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name", item.ProducerId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "BusinessName", item.SupplierId);
        //    ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", item.TypeId);
        //    return View(item);
        //}

        //// POST: Items/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,UnitPrice,BoxPrice,Year,ProducerId,TypeId,SupplierId")] Item item)
        //{
        //    if (id != item.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(item);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ItemExists(item.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name", item.ProducerId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "BusinessName", item.SupplierId);
        //    ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", item.TypeId);
        //    return View(item);
        //}

        //// GET: Items/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var item = await _context.Items
        //        .Include(i => i.Producer)
        //        .Include(i => i.Supplier)
        //        .Include(i => i.Type)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(item);
        //}

        //// POST: Items/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var item = await _context.Items.FindAsync(id);
        //    _context.Items.Remove(item);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }

       
    }
}
