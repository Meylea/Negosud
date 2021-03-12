using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Client.Models
{
    public class ClientCommandLine
    {
        static HttpClient httpClient = new HttpClient();
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public int ItemId { get; set; }
        public int ClientCommandId { get; set; }

        public string ItemName { get; set; }



        public static async Task<List<ClientCommandLine>> GetClientCommandLinesAsync()
        {
            List<ClientCommandLine> cliCommandLines = new List<ClientCommandLine>();
            List<ClientCommandLine> clientLineMatch = new List<ClientCommandLine>();
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/ClientCommandLines" );
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                cliCommandLines = JsonConvert.DeserializeObject<List<ClientCommandLine>>(data);
                foreach (ClientCommandLine match in cliCommandLines)
                {
                    if (match.ClientCommandId.ToString() == Program.ClientCommandValue.ClientCommandValueId)
                    {
                        clientLineMatch.Add(match);
                    }
                }
            }
            return clientLineMatch;
        }

        public static async Task<bool> CreateClientCommandLineAsync(ClientCommandLine clientCommandLine)
        {
            string clientCommandLineJs = JsonConvert.SerializeObject(clientCommandLine);
            StringContent data = new StringContent(clientCommandLineJs, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44311/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.PostAsync("ClientCommandsLine", data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
