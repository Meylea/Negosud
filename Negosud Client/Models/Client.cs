using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class Client
    {
        static HttpClient client = new HttpClient();
        public int Id { get; set; }
        //[Required]
        //[StringLength(50)]
        public string LastName { get; set; }
        //[Required]
        //[StringLength(50)]
        public string FirstName { get; set; }
        //[Required]
        //[StringLength(100)]
        public string Email { get; set; }
        //[StringLength(50)]
        public string Phone { get; set; }
        //[StringLength(200)]
        //[Required]
        public string StreetAddress { get; set; }
        //[StringLength(10)]
        //[Required]
        public string PostalCode { get; set; }
        //[StringLength(50)]
        //[Required]
        public string City { get; set; }

        public ICollection<ClientCommand> ClientCommands { get; set; }

        public static async Task<List<Client>> GetClientsAsync()
        {
            List<Client> clients = new List<Client>();

            HttpResponseMessage response = await client.GetAsync("https://localhost:44311/api/Clients");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                clients = JsonConvert.DeserializeObject<List<Client>>(data);
            }
            return clients;
        }

        public static async Task<bool> CreateProductAsync(ClientsView clients)
        {
            string clientJs = JsonConvert.SerializeObject(clients);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PostAsync("Clients", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
