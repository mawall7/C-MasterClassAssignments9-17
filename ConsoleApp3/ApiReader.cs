using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UltimateCSharpMasterClass
{
    public class ApiReader : IApiReader
    {
        public async Task<string> ReadAsync(string baseAdress, string requestUri)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAdress);
                HttpResponseMessage response = await client.GetAsync(requestUri);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();

            }

        }

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
       


    }
}
