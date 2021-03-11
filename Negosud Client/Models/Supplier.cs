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
            List<Supplier> suppliers = new List<Supplier>();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Suppliers");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);
            }
            return suppliers;
        }

        public static async Task<Supplier> GetOneSupplierAsync(int id)
        {
            Supplier supplier = new Supplier();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Suppliers/" + id);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                supplier = JsonConvert.DeserializeObject<Supplier>(data);
            }
            return supplier;
        }


        public static async Task<List<Supplier>> GetSuppliersByDataAsync(string Search)
        {
            List<Supplier> suppliers = new List<Supplier>();

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Suppliers");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);
            }
            return suppliers;
        }

        public static async void DeleteSupplierAsync(string id)
        {
            string url = "https://localhost:44311/api/Supplier";
            url += "/" + id;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
            }

        }



        public static async Task<bool> CreateSupplierAsync(Supplier supplier)
        {
            string supplierJs = JsonConvert.SerializeObject(supplier);
            StringContent data = new StringContent(supplierJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PostAsync("Suppliers", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static async Task<bool> UpdateProductAsync(Supplier supplier)
        {
            string clientJs = JsonConvert.SerializeObject(supplier);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/Clients/" + supplier.Id.ToString());
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PutAsync(supplier.Id.ToString(), data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
