using System;

namespace net.tellerapps.sunrise_sunset_client
{
    /// <summary>
    /// SunriseSunsetResults class
    /// </summary>
    public class SunriseSunsetResults
    {
        /// <summary>
        /// Sunrise time
        /// </summary>
        public DateTimeOffset Sunrise { get; private set; }
        /// <summary>
        /// Sunset time
        /// </summary>
        public DateTimeOffset Sunset { get; private set; }
        /// <summary>
        /// Solar noon
        /// </summary>
        public DateTimeOffset SolarNoon { get; private set; }
        /// <summary>
        /// Day length
        /// </summary>
        public TimeSpan DayLength { get; private set; }
        /// <summary>
        /// Civil twilight begin
        /// </summary>
        public DateTimeOffset CivilTwilightBegin { get; private set; }
        /// <summary>
        /// Civil twilight end
        /// </summary>
        public DateTimeOffset CivilTwilightEnd { get; private set; }
        /// <summary>
        /// Nautical twilight begin
        /// </summary>
        public DateTimeOffset NauticalTwilightBegin { get; private set; }
        /// <summary>
        /// Nautical twilight end
        /// </summary>
        public DateTimeOffset NauticalTwilightEnd { get; private set; }
        /// <summary>
        /// Astronomical twilight begin
        /// </summary>
        public DateTimeOffset AstronomicalTwilightBegin { get; private set; }
        /// <summary>
        /// Astrononical twilight end
        /// </summary>
        public DateTimeOffset AstronomicalTwilightEnd { get; private set; }

        /// <summary>
        /// SunriseSunsetResults constructor
        /// </summary>
        /// <param name="results">API results object</param>
        public SunriseSunsetResults(Results results)
        {
            Sunrise = results.Sunrise;
            Sunset = results.Sunset;
            SolarNoon = results.SolarNoon;
            DayLength = TimeSpan.FromSeconds(results.DayLength);
            CivilTwilightBegin = results.CivilTwilightBegin;
            CivilTwilightEnd = results.CivilTwilightEnd;
            NauticalTwilightBegin = results.NauticalTwilightBegin;
            NauticalTwilightEnd = results.NauticalTwilightEnd;
            AstronomicalTwilightBegin = results.AstronomicalTwilightBegin;
            AstronomicalTwilightEnd = results.AstronomicalTwilightEnd;
        }
    }
}
