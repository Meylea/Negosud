using System;
using System.Collections.Generic;

namespace Negosud_Client.Models
{
    public class ClientCommand
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int ClientId { get; set; }

        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public Client Client { get; set; }
    }
}
