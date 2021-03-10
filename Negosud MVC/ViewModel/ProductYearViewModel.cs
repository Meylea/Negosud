using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.ViewModel
{
    public class ProductYearViewModel
    {
        public List<Models.Item> Items { get; set; }
        public SelectList Years { get; set; }
        public string ListYear { get; set; }
        public string SearchString { get; set; }
    }
}
