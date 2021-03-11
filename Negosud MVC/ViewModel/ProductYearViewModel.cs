using Microsoft.AspNetCore.Mvc.Rendering;
using Negosud_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.ViewModel
{
    public class ProductYearViewModel
    {
        public List<Item> Items { get; set; }
        public SelectList Years { get; set; }
        public SelectList Types { get; set; }
        public SelectList Producers { get; set; }
        public string ListYear { get; set; }
        public string ListProducer { get; set; }
        public string ListType { get; set; }
        public string SearchString { get; set; }
    }
}
