using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Tvdb.Clients;

public class SeriesClient
{
    public SeriesClient()
    {

        var builder = new HostApplicationBuilder();
        var config = builder.Configuration
            .AddTvdbClient()
            .Build();

        ServiceProvider = builder.Services
            .AddTvdbClient(config)
            .BuildServiceProvider();

        Client = ServiceProvider.GetRequiredService<ISeriesClient>();
    }

    public ServiceProvider ServiceProvider { get; }
    public ISeriesClient Client { get; }

    [Test]
    public void DependencyInjection_Fact() => Client.ShouldNotBeNull();

    [Test]
    [Arguments(234791)] // Heute Show
    public async Task GetSeriesById_Theory(int tvdbId)
    {
        // Arrange

        // Act
        var result = await Client.SeriesGetAsync(tvdbId);
        var data = result.Data;

        // Assert
        result.ShouldNotBeNull();
        result.IsSuccess.ShouldBeTrue();

        data.ShouldNotBeNull();
    }

    [Test]
    [Arguments(234791)] // Heute Show
    public async Task GetSeriesExtendedById_Theory(int tvdbId)
    {
        // Arrange

        // Act
        var result = await Client.ExtendedAsync(tvdbId);
        var data = result.Data;

        // Assert
        result.ShouldNotBeNull();
        result.IsSuccess.ShouldBeTrue();

        data.ShouldNotBeNull();
    }
}