using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
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
    }
}
