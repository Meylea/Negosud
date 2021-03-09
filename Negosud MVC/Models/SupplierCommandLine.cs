using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class SupplierCommandLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public int CommandId { get; set; }

        [Required]
        public Item Item { get; set; }
        public SupplierCommand SupplierCommand { get; set; }
    }
}
