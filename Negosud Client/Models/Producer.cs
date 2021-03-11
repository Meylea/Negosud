﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
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
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Producers");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                producers = JsonConvert.DeserializeObject<List<Producer>>(data);
            }
            return producers;
        }

        public static async Task<Producer> GetOneProducerAsync(int id)
        {
            Producer producer = new Producer();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/Producers/" + id);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                producer = JsonConvert.DeserializeObject<Producer>(data);
            }
            return producer;
        }
    }
}
