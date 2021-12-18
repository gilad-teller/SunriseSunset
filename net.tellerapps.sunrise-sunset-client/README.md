# SunriseSunset
https://sunrise-sunset.org/ API client  
GitHub: https://github.com/gilad-teller/SunriseSunset

## SunriseSunsetClient
This is the basic package. You need to supply it with an `HttpClient` instance that you need to manage by yourself.
```C#
using HttpClient httpClient = new();
SunriseSunsetHttpClient sunriseSunsetClient = new();
Response response = await sunriseSunsetClient.Get(httpClient, 51.5010, -0.1406, new DateTime(2021, 1, 1));
```