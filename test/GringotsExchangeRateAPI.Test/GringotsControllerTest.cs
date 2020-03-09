using System;
using Xunit;
using GringotsExchangeRateAPI.Controllers;

namespace GringotsExchangeRateAPI.Test
{
    public class GringotsControllerTest
    {

        GringotsController controller = new GringotsController();
        [Fact]
        public void GetReturnsAGalleonRatesObject(){
            var returnValue = controller.Get();
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
