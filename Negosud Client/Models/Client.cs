using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class Client
    {
        static HttpClient httpClient = new HttpClient();
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }


        public ICollection<ClientCommand> ClientCommands { get; set; }


        public static async Task<Client> GetOneClientAsync(int id)
        {
            Client client = new Client();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Clients/" + id );
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                client = JsonConvert.DeserializeObject<Client>(data);
            }
            return client;
        }

    }
}
