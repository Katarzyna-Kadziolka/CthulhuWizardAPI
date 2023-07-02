using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Queries.GetinvestigatorDetails;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using MediatR.AspNet.Exceptions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Investigators.Queries;

public class GetInvestigatorDetailsQueryHandlerTests {
    
    [Test]
    public async Task Handle_ShouldReturnInvestigatorDetailsDto() {
        // Arrange
        using var testDb = new RavenTestDb();
        new TestSeeder(testDb).AddInvestigators();
        var request = new GetInvestigatorDetailsdQuery();
        var handler = new GetInvestigatorDetailsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        var investigators =
            TestMapper.Instance.Map<List<InvestigatorDetailsDto>>(session.Query<InvestigatorEntity>().ToList());
        var expectedInvestigator = investigators.First();
        request.Id = Guid.Parse(expectedInvestigator.Id!);

        //Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();

        //Assert
        result.Should().BeEquivalentTo(expectedInvestigator);
    }

    [Test]
    public async Task Handle_NotExistingId_ShouldThrowNotFoundException() {
        // Arrange
        using var testDb = new RavenTestDb();
        new TestSeeder(testDb).AddInvestigators();
        var request = new GetInvestigatorDetailsdQuery();
        var handler = new GetInvestigatorDetailsQueryHandler(testDb, TestMapper.Instance);
        using var session = testDb.Store.OpenSession();
        request.Id = Guid.Empty;
        
        // Act
        var act = () => handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        
        // Assert
        await act.Should()
            .ThrowAsync<NotFoundException>()
            .WithMessage($"Investigator with id {request.Id} not found");
    }
}
