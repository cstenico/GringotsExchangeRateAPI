using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class CalculateGalleonPriceService
    {
        public CalculateGalleonPriceService()
        {
            
        }

        public GalleonRates Calculate( OpenExchangeData currencies_data)
        {
            GalleonRates galleonRates = new GalleonRates();
            foreach (var currency_data in currencies_data.Rates){
                Currency currency = new Currency(currency_data.Key, currency_data.Value * (decimal)5.00);
                galleonRates.ExchangeRates.Add(currency);
            }
            return galleonRates;
        }
    }
}
