using System;
using System.Collections.Generic;

namespace GringotsExchangeRateAPI
{
    public class CalculateGalleonPriceService
    {
        public CalculateGalleonPriceService()
        {
            
        }

        public GringotsRates Calculate( OpenExchangeData currencies_data)
        {
            GringotsRates gringotsRates = new GringotsRates();
            gringotsRates.ExchangeRates = new List<Currency>();
            
            foreach (var currency_data in currencies_data.Rates){
                Currency currency = new Currency(currency_data.Key, CalculateGalleonValue(currency_data.Value), CalculateSickleValue(currency_data.Value), CalculateKnutValue(currency_data.Value));
                gringotsRates.ExchangeRates.Add(currency);
            }
            return gringotsRates;
        }

        private decimal CalculateGalleonValue(decimal currency_price){
            return currency_price * (decimal)5.00;
        }

        private decimal CalculateSickleValue(decimal currency_price){
            return (currency_price * (decimal)5.00) / 17;
        }
        private decimal CalculateKnutValue(decimal currency_price){
            return (currency_price * (decimal)5.00) / 493;
        }
    }
}
