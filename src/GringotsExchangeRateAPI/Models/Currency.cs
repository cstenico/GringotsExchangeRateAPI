using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class Currency
    {

        public Currency(string currencyName, decimal oneGalleon, decimal oneSickle, decimal oneKnut)
        {
            CurrencyName = currencyName;
            OneGalleon = oneGalleon;
            OneSickle = oneSickle;
            OneKnut = oneKnut;
        }
        public string CurrencyName {get; set;}
        public decimal OneGalleon {get; set;}
        public decimal OneSickle {get; set;}
        public decimal OneKnut {get; set;}


    }
}
