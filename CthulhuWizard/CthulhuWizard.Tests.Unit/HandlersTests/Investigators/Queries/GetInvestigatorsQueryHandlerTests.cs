using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Investigators.Queries; 

public class GetInvestigatorsQueryHandlerTests {
    [Test]
    public async Task Handle_ShouldReturnInvestigatorsList() {
        // Arrange
        using var testDb = new RavenTestDb();
        new TestSeeder(testDb).AddInvestigator();
        var request = new GetInvestigatorsQuery();
        var handler = new GetInvestigatorsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        var expectedInvestigators = TestMapper.Instance.Map<List<InvestigatorDto>>(session.Query<InvestigatorEntity>().ToList());
        
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        
        // Assert
        result.Should().HaveSameCount(expectedInvestigators);
        result.Should().BeEquivalentTo(expectedInvestigators);

    }
}