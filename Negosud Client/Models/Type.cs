using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
