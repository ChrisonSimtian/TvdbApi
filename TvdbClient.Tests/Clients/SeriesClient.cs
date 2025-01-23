using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shouldly;
using Xunit.Abstractions;

namespace Tvdb.Clients;

public class SeriesClient
{
    public SeriesClient(ITestOutputHelper outputHelper)
    {
        OutputHelper = outputHelper;

        var builder = new HostApplicationBuilder();
        var config = builder.Configuration
            .AddTvdbClient()
            .Build();

        ServiceProvider = builder.Services
            .AddLogging((builder) => builder.AddXUnit(OutputHelper))
            .AddTvdbClient(config)
            .BuildServiceProvider();

        Client = ServiceProvider.GetRequiredService<ISeriesClient>();
    }

    public ITestOutputHelper OutputHelper { get; }
    public ServiceProvider ServiceProvider { get; }
    public ISeriesClient Client { get; }

    [Fact]
    public void DependencyInjection_Fact() => Client.ShouldNotBeNull();

    [Theory]
    [InlineData(234791)] // Heute Show
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

    [Theory]
    [InlineData(234791)] // Heute Show
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