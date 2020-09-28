using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Kimlik.Tests.Shared;
using Xunit;

namespace Kimlik.Tests
{
    public class HealthCheckTests : IClassFixture<WebApplicationFactory>
    {
        private readonly HttpClient _httpClient;

        public HealthCheckTests(WebApplicationFactory webApplicationFactory)
        {
            _httpClient = webApplicationFactory.CreateClient();
        }

        [Theory]
        [InlineData("/health")]
        [InlineData("/healthz")]
        public async Task When_AppIsUpAndRunning_HealthEndpoints_Should_Work(
            string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.IsSuccessStatusCode.Should().BeTrue();
        }
    }
} 
