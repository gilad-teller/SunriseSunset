using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.tellerapps.sunrise_sunset_client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace net.tellerapps.client_tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public async Task TestGet()
        {
            using HttpClient httpClient = new();
            SunriseSunsetHttpClient sunriseSunsetClient = new();
            SunriseSunsetResults response = await sunriseSunsetClient.Get(httpClient, 51.5010, -0.1406, new DateTime(2021, 1, 1));
            Assert.AreEqual(new DateTimeOffset(2021, 1, 1, 8, 3, 57, TimeSpan.Zero), response.Sunrise);
        }
    }
}
