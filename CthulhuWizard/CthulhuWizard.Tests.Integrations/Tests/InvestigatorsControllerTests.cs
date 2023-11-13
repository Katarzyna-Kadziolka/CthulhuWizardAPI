using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CthulhuWiard.Tests.Integrations.Extensions;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CthulhuWiard.Tests.Integrations.Tests;

public class InvestigatorsControllerTests {
    private HttpClient _client;
    private WebApplicationFactory _factory;

    [SetUp]
    public void Setup() {
        _factory = new WebApplicationFactory();
        _client = _factory.CreateClient();
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
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddInvestigators();
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
    
    [Test]
    public async Task GetDetails_ShouldReturnInvestigatorDetailDto() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddInvestigators();
        using var session = testDb.Store.OpenSession();
        var investigators =
            TestMapper.Instance.Map<List<InvestigatorDetailsDto>>(session.Query<InvestigatorEntity>().ToList());
        var expectedInvestigator = investigators.First();
        var id = expectedInvestigator.Id;
        // Act
        var response = await _client.GetAsync($"api/v1/Investigators/{id}");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var investigator = await response.Content.DeserializeAsync<InvestigatorDetailsDto>();
        // Assert
        investigator.Should().BeEquivalentTo(expectedInvestigator);
    }
    [Test]
    public async Task GetDetails_NewGuid_ShouldReturnNotFound() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddInvestigators();
        using var session = testDb.Store.OpenSession();
        var id = Guid.NewGuid();
        // Act
        var response = await _client.GetAsync($"api/v1/Investigators/{id}");
        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}
