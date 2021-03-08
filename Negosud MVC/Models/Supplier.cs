using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string BusinessName { get; set; }
        [StringLength(200)]
        [Required]
        public string StreetAddress { get; set; }
        [StringLength(10)]
        [Required]
        public string PostCode { get; set; }
        [StringLength(50)]
        [Required]
        public string City { get; set; }
        [StringLength(50)]
        public string ContactLastName { get; set; }
        [StringLength(50)]
        public string ContactFirstName { get; set; }
        [StringLength(50)]
        public string ContactPhone { get; set; }
        [StringLength(100)]
        public string ContactMail { get; set; }
    }
}
