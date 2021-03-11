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
        public async Task<IActionResult> Index(string searchString, string listYear, string listProducer, string listType)
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

            if (!string.IsNullOrEmpty(listProducer))
            {
                items = items.Where(x => x.Producer.Name == listProducer);
            }     
            
            if (!string.IsNullOrEmpty(listType))
            {
                items = items.Where(x => x.Type.Name == listType);
            }

            
            var productYearVM = new ProductYearViewModel
            {
                Producers = new SelectList(await producerQuery.Distinct().ToListAsync()),
                Years = new SelectList(await yearQuery.Distinct().ToListAsync()),
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Items = await items.ToListAsync()
            };

            return View(productYearVM);

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

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }

       
    }
}
