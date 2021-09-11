using System;
using Xunit;

namespace WeatherAPITest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var message = "This Is unit test of API Project";
            Assert.NotNull(message);
        }
    }
}
