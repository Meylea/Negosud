using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Quantité disponible")]
        public int Quantity { get; set; }
        [Display(Name = "Prix unitaire")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Prix au carton")]
        public decimal BoxPrice { get; set; }
        [StringLength(4, MinimumLength = 4)]
        [Required]
        [Display(Name = "Année")]
        public string Year { get; set; }

        [Required]
        public Producer Producer { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public Supplier Supplier { get; set; }
    }
}
