namespace net.tellerapps.sunrise_sunset_client
{
    /// <summary>
    /// Status received from Sunrise Sunset
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Unknows status - status is undocumented
        /// </summary>
        UNKNOWN_STATUS,
        /// <summary>
        /// OK
        /// </summary>
        OK,
        /// <summary>
        /// Invalid request
        /// </summary>
        INVALID_REQUEST,
        /// <summary>
        /// Invalid date received
        /// </summary>
        INVALID_DATE,
        /// <summary>
        /// Unknown error
        /// </summary>
        UNKNOWN_ERROR
    }
}
