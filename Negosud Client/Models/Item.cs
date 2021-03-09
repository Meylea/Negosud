using System;
using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double BoxPrice { get; set; }
        public string Year { get; set; }
        public int ProducerId { get; set; }
        public int TypeId { get; set; }
        public int SupplierId { get; set; }

        public Producer Producer { get; set; }
        public Type Type { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public ICollection<SupplierCommandLine> SupplierCommandLines { get; set; }
    }
}
