using System;
using System.Text.Json.Serialization;

namespace net.tellerapps.sunrise_sunset_client
{
    public class Response
    {
        [JsonInclude]
        public Results Results { get; private set; }
        [JsonInclude]
        public Status Status { get; private set; }
    }
}
