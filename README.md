# TvdbApi
C# Api Client for the TVDB project

## TVDB Project
- [TVDB API](https://thetvdb.com)
- [TVDB API Github](https://github.com/thetvdb/v4-api)
- [TVDB API Documentation](https://thetvdb.github.io/v4-api)

## Usage
The TVDB Team recommends to maintain your own copy of their database or use a caching proxy to reduce the amount of calls being made against their API.
It is entirely up to you as the developer to implement this. This lbirary provides a simple API client AS IS, without any of the recommended caching mechanism.

### Configuration
The Client library relies on config records being present in either your appsettings.json or in a standalone TvdbClientConfig.json:
```json
{
  "TvdbConfiguration": {
    "BaseUrl": "https://api4.thetvdb.com/v4",
    /* This API Key comes from the TVDB Example and obviously needs to be replaced in production */
    "ApiKey": "580c9239-d2f8-4460-a22e-6831900a97a3",
    "Pin": "IPQZOCMN"
  }
}
```
Make sure to replace the API Key in the example with your own API Key in [TVDBs API Key Dashboard](https://www.thetvdb.com/dashboard/account/apikey).

### DI Registration
Register TVDB Client with your DI of choice:

```csharp
        var config = builder.Configuration.AddTvdbClient().Build();
        builder.Services.AddTvdbClient(config);
```

### Using the Clients
```csharp
        var client = serviceProvider.GetRequiredService<ITvdbClient>();
        var series = await client.GetSeriesAsync(121361);
        Console.WriteLine(series.Data.SeriesName);
```