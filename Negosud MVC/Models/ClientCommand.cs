using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Models
{
    public class ClientCommand
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Status { get; set; }
        public int ClientId { get; set; }

        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public Client Client { get; set; }
    }
}
