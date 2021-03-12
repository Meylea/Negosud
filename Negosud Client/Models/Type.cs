using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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

        public static async Task<bool> CreateTypeAsync(Type type)
        {
            string supplierJs = JsonConvert.SerializeObject(type);
            StringContent data = new StringContent(supplierJs, Encoding.UTF8, "application/json");

            using (var Type = new HttpClient())
            {
                Type.BaseAddress = new Uri("https://localhost:44311/api/");
                Type.DefaultRequestHeaders.Accept.Clear();
                Type.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Type.PostAsync("types", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static async void DeleteTypeAsync(string id)
        {
            string url = "https://localhost:44311/api/types";
            url += "/" + id;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsStringAsync();
            }
        }
    }
}
