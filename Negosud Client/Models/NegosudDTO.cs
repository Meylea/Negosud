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
    class NegosudDTO
    {
        static HttpClient client = new HttpClient();


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

        public static async Task<bool> CreateProductAsync(Client clients)
        {
            string clientJs = JsonConvert.SerializeObject(clients);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/Clients");
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
