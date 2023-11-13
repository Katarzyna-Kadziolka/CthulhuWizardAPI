using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Application.Requests.Equipments.Queries.GetEquipments;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Equipments.Queries; 

public class GetEquipmentsQueryHandlerTests {
    [Test]
    public async Task Handle_ShouldReturnEquipmentsDtoList() {
        // Arrange
        using var testDb = new RavenTestDb();
        var request = new GetEquipmentsQuery();
        var handler = new GetEquipmentsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        var equipmentsFromDb = session.Query<EquipmentEntity>().ToList();
        var expectedEquipments = TestMapper.Instance.Map<List<EquipmentDto>>(equipmentsFromDb);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        //Assert
        result.Should().HaveSameCount(expectedEquipments);
        result.Should().BeEquivalentTo(expectedEquipments);
    }
}
