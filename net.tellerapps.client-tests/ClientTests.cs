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
            using HttpClient httpClient = new HttpClient();
            SunriseSunsetHttpClient sunriseSunsetClient = new SunriseSunsetHttpClient();
            Response response = await sunriseSunsetClient.Get(httpClient, 32.8244, 35.0658, new DateTime(2021, 12, 11));
            Assert.IsNotNull(response);
            Assert.AreEqual(Status.OK, response.Status);
            Assert.AreEqual(new DateTimeOffset(2021, 12, 11, 4, 30, 45, TimeSpan.Zero), response.Results.Sunrise);
        }
    }
}
