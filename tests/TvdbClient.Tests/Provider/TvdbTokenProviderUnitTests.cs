using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tvdb.Configuration;

namespace Tvdb.Provider;

public class TvdbTokenProviderUnitTests
{

    public TvdbTokenProviderUnitTests()
    {

        var builder = new HostApplicationBuilder();
        var config = builder.Configuration
            .AddJsonFile("TvdbClientConfig.json", optional: false)
            .Build();

        ServiceProvider = builder.Services
            .Configure<TvdbConfiguration>(config.GetRequiredSection("TvdbConfiguration"))
            .AddScoped<TvdbTokenProvider>()
            .BuildServiceProvider();
    }

    public ServiceProvider ServiceProvider { get; internal set; }

    [Test]
    public async Task AcquireTokenAsync_Fact()
    {
        // Arrange
        var tokenProvider = ServiceProvider.GetRequiredService<TvdbTokenProvider>();

        // Act
        var token = await tokenProvider.AcquireTokenAsync();

        // Assert

        /* Validate Data, Token should be populated and valid for a month */
        token.ShouldNotBeNull();
        Models.Token.TokenType.ShouldBe("Bearer");
        token.CreationTimestamp.ShouldBeLessThanOrEqualTo(DateTime.Now);
        token.IsTokenExpired.ShouldBeFalse();
        token.TokenExpiryDate.ShouldBeGreaterThanOrEqualTo(DateTime.Today.AddMonths(1)); // should be roughly a month, +/- a day

        token.AccessToken.ShouldNotBeNullOrEmpty();
    }
}
