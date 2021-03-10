using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Negosud_Client.Models
{
    public class Item
    {
        static HttpClient client = new HttpClient();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double BoxPrice { get; set; }
        public string Year { get; set; }
        public int ProducerId { get; set; }
        public int TypeId { get; set; }
        public int SupplierId { get; set; }

        public Producer Producer { get; set; }
        public Type Type { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<ClientCommandLine> ClientCommandLines { get; set; }
        public ICollection<SupplierCommandLine> SupplierCommandLines { get; set; }

        public static async Task<List<Item>> GetItemsAsync()
        {
            List<Item> items = new List<Item>();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44369/api/Musics");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                items = JsonConvert.DeserializeObject<List<Item>>(data);
            }
            return items;
        }

        public static async Task<bool> CreateProductAsync(Item item)
        {
            string musicJs = JsonConvert.SerializeObject(item);
            StringContent data = new StringContent(musicJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44369/api/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PostAsync("Items", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
