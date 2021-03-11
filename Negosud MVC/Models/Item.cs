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
        public double UnitPrice { get; set; }
        [Display(Name = "Prix au carton")]
        public double BoxPrice { get; set; }
        [StringLength(4, MinimumLength = 4)]
        [Required]
        [Display(Name = "Année")]
        public string Year { get; set; }
        public string ImgUrl { get; set; }
        public int ProducerId { get; set; }
        public int TypeId { get; set; }
        public int SupplierId { get; set; }

        public Producer Producer { get; set; }
        public Type Type { get; set; }
        public Supplier Supplier { get; set; }
        public string imgURL { get; set; }


        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public ICollection<SupplierCommandLine> SupplierCommandLines { get; set; }
    }
}
