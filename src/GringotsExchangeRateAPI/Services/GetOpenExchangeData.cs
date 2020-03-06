using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Net.Http;


namespace GringotsExchangeRateAPI.Services
{
    public class GetOpenExchangeData
    {

        public GetOpenExchangeData()
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
