using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class Producer
    {
        static HttpClient httpClient = new HttpClient();
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }

        public static async Task<List<Producer>> GetProducersAsync()
        {

            List<Producer> producers = new List<Producer>();
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Producers");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    producers = JsonConvert.DeserializeObject<List<Producer>>(data);
                }
            }
            return producers;
        }

        public static async Task<Producer> GetOneProducerAsync(int id)
            {
                Producer producer = new Producer();
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Producers/" + id);
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        producer = JsonConvert.DeserializeObject<Producer>(data);
                    }
                }
                return producer;
            }

        public static async void DeleteRowAsync(string GetUrl)
        {
            string url = "https://localhost:44311/api/Producers";
            url += "/" + GetUrl;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

            }

        }

        public static async Task<bool> CreateProducerAsync(Producer producer)
        {
            string clientJs = JsonConvert.SerializeObject(producer);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44311/api/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.PostAsync("Producers", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static async Task<bool> UpdateProducerAsync(Producer producer, string idUser)
        {
            string clientJs = JsonConvert.SerializeObject(producer);
            StringContent data = new StringContent(clientJs, Encoding.UTF8, "application/json");

            using (var Producer = new HttpClient())
            {
                Producer.BaseAddress = new Uri("https://localhost:44311/api/Producers/" + idUser);
                Producer.DefaultRequestHeaders.Accept.Clear();
                Producer.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Producer.PutAsync(idUser, data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
