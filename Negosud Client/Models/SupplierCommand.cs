using System;
using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class SupplierCommand
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public ICollection<SupplierCommandLine> SupplierCommandLines { get; set; }
    }
}
