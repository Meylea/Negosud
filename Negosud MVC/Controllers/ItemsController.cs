using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Negosud_MVC.Data;
using Negosud_MVC.ViewModel;

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
        public async Task<IActionResult> Index(string searchString, string listYear, string producer, string type)
        {
            //search by year
            IQueryable<string> yearQuery = from y in _context.Items
                                           orderby y.Year
                                           select y.Year;
            //search by producer
            IQueryable<string> producerQuery = from p in _context.Items
                                           orderby p.Producer.Name
                                               select p.Producer.Name;

            IQueryable<string> typeQuery = from t in _context.Items
                                           orderby t.Type.Name
                                               select t.Type.Name;

            //search by string
            var items = from m in _context.Items
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
            }

            
            //search for select list in veiw
            if (!string.IsNullOrEmpty(listYear))
            {
                items = items.Where(x => x.Year == listYear);
            }

            if (!string.IsNullOrEmpty(producer))
            {
                items = items.Where(x => x.Producer.Name == producer);
            }     
            
            if (!string.IsNullOrEmpty(type))
            {
                items = items.Where(x => x.Type.Name == type);
            }

            
            var productYearVM = new ProductYearViewModel
            {
                Producers = new SelectList(await producerQuery.Distinct().ToListAsync()),
                Years = new SelectList(await yearQuery.Distinct().ToListAsync()),
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Items = await items.ToListAsync()
            };

            return View(productYearVM);


            //search by producer

            /*var negosudContext = _context.Items.Include(i => i.Producer).Include(i => i.Supplier).Include(i => i.Type);*/

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
