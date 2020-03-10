using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class Currency
    {

        public Currency(string name, decimal galleonPrice, decimal sicklePrice, decimal knutPrice)
        {
            Name = name;
            GalleonPrice = galleonPrice;
            SicklePrice = sicklePrice;
            KnutPrice = knutPrice;
        }
        public string Name {get; set;}
        public decimal GalleonPrice {get; set;}
        public decimal SicklePrice {get; set;}
        public decimal KnutPrice {get; set;}


    }
}
