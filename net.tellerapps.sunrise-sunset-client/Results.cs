using System;
using System.Text.Json.Serialization;

namespace net.tellerapps.sunrise_sunset_client
{
    public class Results
    {
        [JsonInclude]
        public DateTimeOffset Sunrise { get; private set; }
        [JsonInclude]
        public DateTimeOffset Sunset { get; private set; }
        [JsonInclude]
        [JsonPropertyName("solar_noon")]
        public DateTimeOffset SolarNoon { get; private set; }
        [JsonInclude]
        [JsonPropertyName("day_length")]
        public int DayLength { get; private set; }
        [JsonInclude]
        [JsonPropertyName("civil_twilight_begin")]
        public DateTimeOffset CivilTwilightBegin { get; private set; }
        [JsonInclude]
        [JsonPropertyName("civil_twilight_end")]
        public DateTimeOffset CivilTwilightEnd { get; private set; }
        [JsonInclude]
        [JsonPropertyName("nautical_twilight_begin")]
        public DateTimeOffset NauticalTwilightBegin { get; private set; }
        [JsonInclude]
        [JsonPropertyName("nautical_twilight_end")]
        public DateTimeOffset NauticalTwilightEnd { get; private set; }
        [JsonInclude]
        [JsonPropertyName("astronomical_twilight_begin")]
        public DateTimeOffset AstronomicalTwilightBegin { get; private set; }
        [JsonInclude]
        [JsonPropertyName("astronomical_twilight_end")]
        public DateTimeOffset AstronomicalTwilightEnd { get; private set; }
    }
}
