using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string BusinessName { get; set; }
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
