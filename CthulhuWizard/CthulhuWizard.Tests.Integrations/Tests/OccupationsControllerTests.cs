using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CthulhuWiard.Tests.Integrations.Extensions;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Occupations;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CthulhuWiard.Tests.Integrations.Tests; 

public class OccupationsControllerTests {
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
    public async Task Get_ShouldReturnOccupationDtoList() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddOccupations();
        using var session = testDb.Store.OpenSession();
        var occupationsFromDb = session.Query<OccupationEntity>().ToList();
        var expectedOccupations =
            TestMapper.Instance.Map<List<OccupationDto>>(occupationsFromDb);
        // Act
        var response = await _client.GetAsync("api/v1/Occupations");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var occupations = await response.Content.DeserializeAsync<List<OccupationDto>>();
        // Assert
        occupations.Should().BeEquivalentTo(expectedOccupations);
    }
    [Test]
    public async Task GetDetails_ShouldReturnOccupationDetailDto() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddOccupations();
        using var session = testDb.Store.OpenSession();
        var occupationsFromDb = session.Query<OccupationEntity>().ToList();
        var occupations =
            TestMapper.Instance.Map<List<OccupationDetailsDto>>(occupationsFromDb);
        var expectedOccupation = occupations.First();
        var id = expectedOccupation.Id;
        // Act
        var response = await _client.GetAsync($"api/v1/Occupations/{id}");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var occupation = await response.Content.DeserializeAsync<OccupationDetailsDto>();
        // Assert
        occupation.Should().BeEquivalentTo(expectedOccupation);
    }
    [Test]
    public async Task GetDetails_NewGuid_ShouldReturnNotFound() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        new TestSeeder(testDb).AddOccupations();
        using var session = testDb.Store.OpenSession();
        var id = Guid.NewGuid();
        // Act
        var response = await _client.GetAsync($"api/v1/Occupations/{id}");
        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}
