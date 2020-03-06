using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class OpenExchangeData
    {
        public Dictionary<string, decimal> Rates {get; set;}
        public string Base {get; set;}

        public string Date {get; set;}
    }
}
