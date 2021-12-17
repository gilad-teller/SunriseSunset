# SunriseSunset
https://sunrise-sunset.org/ API client

## SunriseSunsetClient
This is the basic package. You need to supply it with an `HttpClient` instance that you need to manage by yourself.
```C#
using HttpClient httpClient = new();
SunriseSunsetHttpClient sunriseSunsetClient = new();
Response response = await sunriseSunsetClient.Get(httpClient, 51.5010, -0.1406, new DateTime(2021, 1, 1));
```

## SunriseSunsetClient Dependency Injection
This extension allows you to easily add `SunriseSunsetClient` to your .Net 5 application
Add this to the Startup:
```C#
services.AddSunriseSunsetClient();
```
When adding this service, `SunriseSunsetService` and `SunriseSunsetHttpClient` are added as scoped services. Also, an `HttpClient` is registered and binded to `SunriseSunsetService`. This means you don't need to manage the `HttpClient`.
You can then consume `SunriseSunsetService` as a dependency.
```C#
public class MyService
{
	private readonly SunriseSunsetService _sunriseSunsetService;
	
	public MyService(SunriseSunsetService sunriseSunsetService)
	{
		_sunriseSunsetService = sunriseSunsetService;
	}

	public async Task<Response> Get()
	{
		return await _sunriseSunsetService.Get(51.5010, -0.1406, new DateTime(2021, 1, 1));
	}
}
```