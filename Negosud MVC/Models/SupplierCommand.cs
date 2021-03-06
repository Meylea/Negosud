using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class SupplierCommand
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Status { get; set; }

        public ICollection<SupplierCommandLine> SupplierCommandLines { get; set; }
    }
}
