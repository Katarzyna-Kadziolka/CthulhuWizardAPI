using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CthulhuWiard.Tests.Integrations.Extensions;
using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CthulhuWiard.Tests.Integrations.Tests; 

public class EquipmentsControllerTests {
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
    public async Task Get_ShouldReturnEquipmentDtoList() {
        // Arrange
        var testDb = _factory.Services.GetRequiredService<IRavenDbContext>();
        using var session = testDb.Store.OpenSession();
        var equipmentFromDb = session.Query<EquipmentEntity>().ToList();
        var expectedEquipments = TestMapper.Instance.Map<List<EquipmentDto>>(equipmentFromDb);
        // Act
        var response = await _client.GetAsync("api/v1/Equipments");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var equipments = await response.Content.DeserializeAsync<List<EquipmentDto>>();
        // Assert
        equipments.Should().BeEquivalentTo(expectedEquipments);

    }
}
