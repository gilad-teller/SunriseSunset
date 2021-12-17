using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace net.tellerapps.sunrise_sunset_client.dependency_injection
{
    /// <summary>
    /// Sunrise Sunset Service
    /// </summary>
    public class SunriseSunsetService
    {
        private readonly SunriseSunsetHttpClient _sunriseSunsetHttpClient;
        private readonly IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// Sunrise Sunset Service constructor
        /// </summary>
        /// <param name="sunriseSunsetHttpClient">Http client for SunriseSunset</param>
        /// <param name="httpClientFactory">Http client factory</param>
        public SunriseSunsetService(SunriseSunsetHttpClient sunriseSunsetHttpClient, IHttpClientFactory httpClientFactory)
        {
            _sunriseSunsetHttpClient = sunriseSunsetHttpClient;
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Get sunrise sunset data
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="date">Date</param>
        /// <returns>Sunrise sunset data</returns>
        public async Task<SunriseSunsetResults> Get(double latitude, double longitude, DateTime date)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient(nameof(SunriseSunsetService));
            SunriseSunsetResults response = await _sunriseSunsetHttpClient.Get(httpClient, latitude, longitude, date);
            return response;
        }
    }
}
