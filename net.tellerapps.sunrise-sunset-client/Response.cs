using System.Text.Json.Serialization;

namespace net.tellerapps.sunrise_sunset_client
{
    /// <summary>
    /// Response class
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Results object
        /// </summary>
        [JsonInclude]
        public Results Results { get; private set; }
        /// <summary>
        /// Response status
        /// </summary>
        [JsonInclude]
        public Status Status { get; private set; }
    }
}
