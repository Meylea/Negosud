using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class Supplier
    {
        static HttpClient httpClient = new HttpClient();
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

        public ICollection<ClientCommand> ClientCommands { get; set; }

        public static async Task<List<Supplier>> GetSuppliersAsync()
        {
            List<Supplier> clients = new List<Supplier>();

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Clients");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                clients = JsonConvert.DeserializeObject<List<Supplier>>(data);
            }
            return clients;
        }

        public static async Task<List<Supplier>> GetSuppliersAsync(string Search)
        {
            List<Supplier> suppliers = new List<Supplier>();

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Clients");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);
            }
            return suppliers;
        }

        public static async Task<Supplier> GetOneClientsAsync(string GetUrl)
        {
            Supplier suppliers = new Supplier();
            string url = "https://localhost:44311/api/Clients";
            url += "/" + GetUrl;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<Supplier>(data);
            }
            return suppliers;
        }

        public static async void DeleteRowAsync(string GetUrl)
        {
            string url = "https://localhost:44311/api/Clients";
            url += "/" + GetUrl;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

            }

        }



        public static async Task<bool> CreateProductAsync(Supplier suppliers)
        {
            string suppliersJs = JsonConvert.SerializeObject(suppliers);
            StringContent data = new StringContent(suppliersJs, Encoding.UTF8, "application/json");

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

        public static async Task<bool> UpdateProductAsync(Supplier suppliers, string idUser)
        {
            string clientJs = JsonConvert.SerializeObject(suppliers);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/Clients/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PutAsync("Clients", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
