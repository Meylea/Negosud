using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(200)]
        [Required]
        public string StreetAddress { get; set; }
        [StringLength(10)]
        [Required]
        public string PostalCode { get; set; }
        [StringLength(50)]
        [Required]
        public string City { get; set; }


        public ICollection<ClientCommand> ClientCommands {get; set;}
    }
}
