using System;

namespace net.tellerapps.sunrise_sunset_client
{
    /// <summary>
    /// Exception class for Sunrise Sunset errors
    /// </summary>
    public class SunriseSunsetException : Exception
    {
        /// <summary>
        /// Status received from SunriseSunset API
        /// </summary>
        public Status SunriseSunseResponseStatus { get; set; }

        /// <summary>
        /// Constructor for SunriseSunsetException
        /// </summary>
        /// <param name="sunriseSunseResponseStatus">Response status from SunriseSunset</param>
        /// <param name="exception">Exception</param>
        public SunriseSunsetException(Status sunriseSunseResponseStatus, Exception exception) : base(exception.Message, exception)
        {
            SunriseSunseResponseStatus = sunriseSunseResponseStatus;
        }
    }
}
