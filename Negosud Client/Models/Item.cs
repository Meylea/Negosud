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
        static HttpClient httpClient = new HttpClient();
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

        public string SupplierName { get; set; }
        public string TypeName { get; set; }
        public string ProducerName { get; set; }

        public static async Task<List<Item>> GetItemsAsync()
        {
            List<Item> items = new List<Item>();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Items");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                items = JsonConvert.DeserializeObject<List<Item>>(data);
                foreach (Item item in items)
                {
                    Type type =  await Models.Type.GetOneTypeAsync(item.TypeId);
                    item.TypeName = type.Name;
                    Supplier supplier = await Supplier.GetOneSupplierAsync(item.SupplierId);
                    item.SupplierName = supplier.BusinessName;
                    Producer producer = await Producer.GetOneProducerAsync(item.ProducerId);
                    item.ProducerName = producer.Name;
                }
            }
            return items;
        }

        public static async Task<Item> GetOneItemAsync(int id)
        {
            Item item = new Item();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/items/" + id);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                item = JsonConvert.DeserializeObject<Item>(data);
            }
            return item;
        }

        public static async Task<bool> CreateItemAsync(Item item)
        {
            string itemJs = JsonConvert.SerializeObject(item);
            StringContent data = new StringContent(itemJs, Encoding.UTF8, "application/json");

            using (var htttpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44311/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.PostAsync("Items", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }  
            }
            return false;
        }

        public static async Task<bool> UpdateItemAsync(Item item)
        {
            string itemJs = JsonConvert.SerializeObject(item);
            StringContent data = new StringContent(itemJs, Encoding.UTF8, "application/json");

            using (var htttpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44311/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.PutAsync("Items/" + item.Id, data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
