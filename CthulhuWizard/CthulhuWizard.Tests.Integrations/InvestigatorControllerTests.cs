using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CthulhuWiard.Tests.Integrations.Extensions;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
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
    public async Task Post_ShouldReturnInvestigatorDetailsDto() {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        // Act
        var response = await _client.PostAsJsonAsync("api/v1/Investigators", command);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var investigatorDto = await response.Content.DeserializeAsync<InvestigatorDetailsDto>();
        // Assert
        investigatorDto.Should().BeEquivalentTo(command);
    }

    [Test]
    public async Task Get_ShouldReturnInvestigatorDtoList() {
        // Arrange
        using var testDb = new RavenTestDb();
        using var session = testDb.Store.OpenSession();
        var expectedInvestigators =
            TestMapper.Instance.Map<List<InvestigatorDto>>(session.Query<InvestigatorEntity>().ToList());
        // Act
        var response = await _client.GetAsync("api/v1/Investigators");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var investigators = await response.Content.DeserializeAsync<List<InvestigatorDto>>();
        // Assert
        investigators.Should().BeEquivalentTo(expectedInvestigators);
    }
}