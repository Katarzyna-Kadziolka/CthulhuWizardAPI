using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CthulhuWiard.Tests.Integrations.Extensions;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWiard.Tests.Integrations;

public class InvestigatorControllerTests {
    private HttpClient _client;

    [SetUp]
    public void Setup() {
        var factory = new WebApplicationFactory();
        _client = factory.CreateClient();
    }

    [TearDown]
    public void CleanUp() {
        _client.Dispose();
    }
    [Test]
    public async Task Post_ShouldReturnInvestigatorDto() {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        // Act
        var response = await _client.PostAsJsonAsync("api/v1/Investigator", command);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var investigatorDto = await response.Content.DeserializeAsync<InvestigatorDto>();
        // Assert
        investigatorDto.Should().BeEquivalentTo(command);
    }
}