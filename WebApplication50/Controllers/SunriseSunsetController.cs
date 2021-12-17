using Microsoft.AspNetCore.Mvc;
using net.tellerapps.sunrise_sunset_client;
using net.tellerapps.sunrise_sunset_client.dependency_injection;
using System;
using System.Threading.Tasks;

namespace WebApplication50.Controllers
{
    /// <summary>
    /// API controller for SunriseSunset
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SunriseSunsetController : ControllerBase
    {
        private readonly SunriseSunsetService _sunriseSunsetService;

        /// <summary>
        /// SunriseSunsetController constructor
        /// </summary>
        /// <param name="sunriseSunsetService">SunriseSunsetService injected dependency</param>
        public SunriseSunsetController(SunriseSunsetService sunriseSunsetService)
        {
            _sunriseSunsetService = sunriseSunsetService;
        }

        /// <summary>
        /// Get sunrise and sunset data
        /// </summary>
        /// <param name="latitude">Longitude</param>
        /// <param name="longitude">Latitude</param>
        /// <param name="date">Date</param>
        /// <returns>Sunrise and sunset data</returns>
        [HttpGet]
        public async Task<Response> Get(double latitude, double longitude, DateTime date)
        {
            return await _sunriseSunsetService.Get(latitude, longitude, date);
        }
    }
}
