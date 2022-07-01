using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupations;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Occupations.Queries; 

public class GetOccupationsQueryHandlerTests {
    [Test]
    public async Task Handle_ShouldReturnOccupationsList() {
        // Arrange
        using var testDb = new RavenTestDb();
        new TestSeeder(testDb).AddOccupations();
        var request = new GetOccupationsQuery();
        var handler = new GetOccupationsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        var expectedOccupations = TestMapper.Instance.Map<List<OccupationDto>>(session.Query<OccupationEntity>().ToList());
        
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        
        // Assert
        result.Should().HaveSameCount(expectedOccupations);
        result.Should().BeEquivalentTo(expectedOccupations);

    }
}