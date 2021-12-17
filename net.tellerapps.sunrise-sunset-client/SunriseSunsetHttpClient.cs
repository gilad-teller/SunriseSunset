using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace net.tellerapps.sunrise_sunset_client
{
    public class SunriseSunsetHttpClient
    {
        public async Task<Response> Get(HttpClient httpClient, double latitude, double longitude, DateTime date)
        {
            Response responseObj = null;
            try
            {
                string uri = BuildUri(latitude, longitude, date);
                using HttpResponseMessage response = await httpClient.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                responseObj = JsonSerializer.Deserialize<Response>(json, new JsonSerializerOptions()
                {
                    Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    },
                    PropertyNameCaseInsensitive = true
                });
                response.EnsureSuccessStatusCode();
                return responseObj;
            }
            catch (Exception ex)
            {
                if (responseObj == null)
                {
                    throw;
                }
                SunriseSunsetException exception = new SunriseSunsetException(responseObj.Status, ex);
                throw exception;
            }
        }

        private string BuildUri(double latitude, double longitude, DateTime date)
        {
            NameValueCollection parameters = HttpUtility.ParseQueryString(string.Empty);
            parameters["lat"] = latitude.ToString();
            parameters["lng"] = longitude.ToString();
            parameters["date"] = date.ToString("yyyy-MM-dd");
            parameters["formatted"] = "0";
            UriBuilder ub = new UriBuilder("https://api.sunrise-sunset.org/json")
            {
                Query = HttpUtility.UrlDecode(parameters.ToString())
            };
            return ub.ToString();
        }
    }
}
