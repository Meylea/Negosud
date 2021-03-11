using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class Type
    {
        static HttpClient httpClient = new HttpClient();
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }

        public static async Task<List<Type>> GetTypesAsync()
        {
            List<Type> types = new List<Type>();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Types");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                types = JsonConvert.DeserializeObject<List<Type>>(data);
            }
            return types;
        }

        public static async Task<Type> GetOneTypeAsync(int id)
        {
            Type type = new Type();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Types/" + id);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                type = JsonConvert.DeserializeObject<Type>(data);
            }
            return type;
        }
    }
}
