using System;

namespace net.tellerapps.sunrise_sunset_client
{
    public class SunriseSunsetException : Exception
    {
        public Status SunriseSunseResponseStatus { get; set; }

        public SunriseSunsetException(Status sunriseSunseResponseStatus, Exception exception) : base(exception.Message, exception)
        {
            SunriseSunseResponseStatus = sunriseSunseResponseStatus;
        }
    }
}
