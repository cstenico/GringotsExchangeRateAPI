using System;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;


namespace GringotsExchangeRateAPI.Services
{
    public class GetOpenExchangeDataService
    {

        public GetOpenExchangeDataService()
        {
            
        }

        public async Task<OpenExchangeData> GetData()
        {

            var client = new HttpClient();

            var result = await client.GetStringAsync("https://api.exchangeratesapi.io/latest?base=GBP");

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var openExchangeData = JsonSerializer.Deserialize<OpenExchangeData>(result.ToString(), options);

            return openExchangeData;
        }
    }
}
