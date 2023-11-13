using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupations;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Occupations.Queries; 

public class GetOccupationsQueryHandlerTests {
    [Test]
    public async Task Handle_ShouldReturnOccupationsList() {
        // Arrange
        using var testDb = new RavenTestDb();
        var request = new GetOccupationsQuery();
        var handler = new GetOccupationsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        var occupationsFromDb = session.Query<OccupationEntity>().ToList();
        var expectedOccupations = TestMapper.Instance
            .Map<List<OccupationDto>>(occupationsFromDb);
        
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        
        // Assert
        result.Should().HaveSameCount(expectedOccupations);
        result.Should().BeEquivalentTo(expectedOccupations);
    }
}
