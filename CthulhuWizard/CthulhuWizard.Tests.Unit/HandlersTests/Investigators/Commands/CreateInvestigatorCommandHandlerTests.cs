using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Investigators.Commands; 

public class CreateInvestigatorCommandHandlerTests {

    [Test]
    public async Task Handle_ShouldCreateInvestigator() {
        // Arrange
        using var testDb = new RavenTestDb();
        var request = new CreateInvestigatorCommandGenerator().Generate();
        var handler = new CreateInvestigatorCommandHandler(testDb, TestMapper.Instance);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        testDb.WaitForUserToContinueTheTest();
        // Assert
        using var session = testDb.Store.OpenSession();
        var investigators = session.Query<InvestigatorEntity>().ToList();
        investigators.Should().HaveCount(1);
        var investigator = investigators.First();
        result.Should().BeEquivalentTo(request);
        investigator.Should().BeEquivalentTo(request);
    }
}