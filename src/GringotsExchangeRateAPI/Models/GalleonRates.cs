using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class GalleonRates
    {
        public GalleonRates()
        {
           ExchangeRates = new List<Currency>();
        }
            
        public List<Currency> ExchangeRates {get; set;}
    }
}
