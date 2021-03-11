using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
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
        public int CientCommandId { get; set; }



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
                    if (match.CientCommandId.ToString() == Program.ClientCommandValue.ClientCommandValueId)
                    {
                        clientLineMatch.Add(match);
                    }
                }
            }
            return clientLineMatch;
        }

    }
}
