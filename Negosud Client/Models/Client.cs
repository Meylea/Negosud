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
        static HttpClient httpClient = new HttpClient();
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

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Clients");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                clients = JsonConvert.DeserializeObject<List<Client>>(data);
            }
            return clients;
        }

        public static async Task<List<Client>> GetClientsAsync(string Search)
        {
            List<Client> clients = new List<Client>();

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Clients");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                clients = JsonConvert.DeserializeObject<List<Client>>(data);
            }
            return clients;
        }

        public static async Task<Client> GetOneClientsAsync(string GetUrl)
        {
            Client client = new Client();
            string url = "https://localhost:44311/api/Clients";
            url += "/"+GetUrl;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                client = JsonConvert.DeserializeObject<Client>(data);
            }
            return client;
        }
        
        public static async void DeleteRowAsync(string GetUrl)
        {
            string url = "https://localhost:44311/api/Clients";
            url += "/"+GetUrl;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                
            }
            
        }

        public static async Task<bool> CreateProductAsync(Client clients)
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

        public static async Task<bool> UpdateProductAsync(Client clients,string idUser)
        {
            string clientJs = JsonConvert.SerializeObject(clients);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/Clients/"+idUser);
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PutAsync(idUser, data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
