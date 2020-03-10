## GringotsExchangeRateAPI
An API that provides the value of the galleon (UK Wizard World Currency) in many currencies as possible.

This API focus is practicing C# and Azure DevOps, but I hope for it to be available for everyone

Link to access: [https://gringotsexchangerateapi.azurewebsites.net/](https://gringotsexchangerateapi.azurewebsites.net/)

## This is a work in progress

## Usage

### /gringots

Returns the value of **1 (one) Galleon**, **1 Sickle** and **1 Knut** in severel currencies
Example:
```json
{
    "exchangeRates": [
        {
            "name": "CAD",
            "galleonPrice": 8.933659865,
            "sicklePrice": 0.5255094038235294117647058824,
            "knutPrice": 0.018121013924949290060851927
        }
    ]
}
```

### /gringots/{country}

Return only the selected currency. Available currencies:
CAD, HKD, ISK, PHP, DKK, HUF, CZK, RON, SEK, IDR, INR, BRL, RUB, HRK, JPY, THB, CHF, EUR, MYR, BGN, TRY, CNY, NOK, NZD, ZAR, USD, MXN, SGD, AUD, ILS, KRW, PLN

## Swagger
The documentation can be found in [https://gringotsexchangerateapi.azurewebsites.net/](https://gringotsexchangerateapi.azurewebsites.net/)