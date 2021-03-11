using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Negosud_Client.Models
{
    public class ClientCommand
    {
        static HttpClient httpClient = new HttpClient();
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int ClientId { get; set; }

        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public string ClientName { get; set; }

        public static async Task<List<ClientCommand>> GetClientCommandsAsync()
        {
            List<ClientCommand> cliCommands = new List<ClientCommand>();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/ClientCommands");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                cliCommands = JsonConvert.DeserializeObject<List<ClientCommand>>(data);
                 foreach (ClientCommand clientCommand in cliCommands)
                 {
                     Client client = await Client.GetOneClientAsync(clientCommand.ClientId);
                     clientCommand.ClientName = client.LastName + " " + client.FirstName;
                 }
            }
            return cliCommands;
        }

        public static async Task<ClientCommand> GetOneClientCommandAsync(int id)
        {
            ClientCommand cliCommand = new ClientCommand();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/ClientCommands/" + id);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                cliCommand = JsonConvert.DeserializeObject<ClientCommand>(data);
                
                Client client = await Client.GetOneClientAsync(cliCommand.ClientId);
                cliCommand.ClientName = client.LastName + " " + client.FirstName;
            }
            return cliCommand;
        }


    }
}
