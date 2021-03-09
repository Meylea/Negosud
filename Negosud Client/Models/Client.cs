using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }


        public ICollection<ClientCommand> ClientCommands { get; set; }
    }
}
