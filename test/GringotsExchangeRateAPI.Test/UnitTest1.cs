using System;
using Xunit;
using GringotsExchangeRateAPI.Controllers;

namespace GringotsExchangeRateAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsSomething(){
            var returnValue = controller.Get();
            Assert.Equal("Hello World", returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
