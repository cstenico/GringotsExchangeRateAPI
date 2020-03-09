using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Net.Http;
using GringotsExchangeRateAPI.Services;


namespace GringotsExchangeRateAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GringotsController : ControllerBase
    {

        public GringotsController()
        {
            
        }

        [HttpGet]
        public async Task<string> Get()
        {

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var openExchangeData = await new GetOpenExchangeDataService().GetData();

            var galleonRates = new CalculateGalleonPriceService().Calculate(openExchangeData);

            var galleonJSON = JsonSerializer.Serialize(galleonRates, options);

            return galleonJSON;
        }
    }
}
