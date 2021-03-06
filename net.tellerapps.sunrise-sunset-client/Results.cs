using System;
using System.Text.Json.Serialization;

namespace net.tellerapps.sunrise_sunset_client
{
    /// <summary>
    /// Results class
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Sunrise time
        /// </summary>
        [JsonInclude]
        public DateTimeOffset Sunrise { get; private set; }
        /// <summary>
        /// Sunset time
        /// </summary>
        [JsonInclude]
        public DateTimeOffset Sunset { get; private set; }
        /// <summary>
        /// Solar noon
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("solar_noon")]
        public DateTimeOffset SolarNoon { get; private set; }
        /// <summary>
        /// Day length in seconds
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("day_length")]
        public int DayLength { get; private set; }
        /// <summary>
        /// Civil twilight begin
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("civil_twilight_begin")]
        public DateTimeOffset CivilTwilightBegin { get; private set; }
        /// <summary>
        /// Civil twilight end
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("civil_twilight_end")]
        public DateTimeOffset CivilTwilightEnd { get; private set; }
        /// <summary>
        /// Nautical twilight begin
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("nautical_twilight_begin")]
        public DateTimeOffset NauticalTwilightBegin { get; private set; }
        /// <summary>
        /// Nautical twilight end
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("nautical_twilight_end")]
        public DateTimeOffset NauticalTwilightEnd { get; private set; }
        /// <summary>
        /// Astronomical twilight begin
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("astronomical_twilight_begin")]
        public DateTimeOffset AstronomicalTwilightBegin { get; private set; }
        /// <summary>
        /// Astrononical twilight end
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("astronomical_twilight_end")]
        public DateTimeOffset AstronomicalTwilightEnd { get; private set; }
    }
}
