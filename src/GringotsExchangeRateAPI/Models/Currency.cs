using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class Currency
    {

        public Currency(string name, decimal price)
        {
            Name = name;
            Price = price;  
        }
        public string Name {get; set;}
        public decimal Price {get; set;}
    }
}
