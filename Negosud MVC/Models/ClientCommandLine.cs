using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class ClientCommandLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public int ItemId { get; set; }
        public int ClientCommandId { get; set; }

        public Item Item { get; set; }
        public ClientCommand ClientCommand { get; set;}
    }
}
