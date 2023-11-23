using System;
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
using Raven.Client.Documents;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Equipments.Queries; 

public class GetEquipmentsQueryHandlerTests {
    [Test]
    public async Task Handle_ShouldReturnEquipmentsDtoList() {
        // Arrange
        using var testDb = new RavenTestDb();
        new TestSeeder(testDb).AddEquipments();
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
    [Test]
    public async Task Handle_Name_ShouldReturnEquipmentsDtoListWithGivenName() {
        // Arrange
        using var testDb = new RavenTestDb();
        var seededEquipments = new List<EquipmentEntity> {
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "Test",
                Type = "Test type",
                Price = 1
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "Test type",
                Price = 2
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "TestB",
                Type = "Test type",
                Price = 3
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATestB",
                Type = "Test type",
                Price = 4
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "AB",
                Type = "Test type",
                Price = 5
            }
        };
        var request = new GetEquipmentsQuery();
        request.Name = "Test";
        var handler = new GetEquipmentsQueryHandler(testDb, TestMapper.Instance);
        
        using var session = testDb.Store.OpenSession();
        foreach (var equipment in seededEquipments) {
            session.Store(equipment); 
        }
        session.SaveChanges();
        
        var equipmentsFromDb = session
            .Query<EquipmentEntity>()
            .Search(a => a.Name, $"*{request.Name}*" )
            .ToList();
        var expectedEquipments = TestMapper.Instance.Map<List<EquipmentDto>>(equipmentsFromDb);

        // Act
        testDb.WaitForIndexing();
        var result = await handler.Handle(request, CancellationToken.None);
        //Assert
        result.Should().HaveSameCount(expectedEquipments);
        result.Should().BeEquivalentTo(expectedEquipments);
    }
    [Test]
    public async Task Handle_Price_ShouldReturnEquipmentsDtoListWithPriceLowerOrEqualToGiven() {
        // Arrange
        using var testDb = new RavenTestDb();
        var seededEquipments = new List<EquipmentEntity> {
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "Test",
                Type = "Test type",
                Price = 1
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "Test type",
                Price = 2
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "TestB",
                Type = "Test type",
                Price = 3
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATestB",
                Type = "Test type",
                Price = 4
            }
        };
        var request = new GetEquipmentsQuery();
        request.Price = 2;
        var handler = new GetEquipmentsQueryHandler(testDb, TestMapper.Instance);
        
        using var session = testDb.Store.OpenSession();
        foreach (var equipment in seededEquipments) {
            session.Store(equipment); 
        }
        session.SaveChanges();
        
        var equipmentsFromDb = session
            .Query<EquipmentEntity>()
            .Where(a => a.Price <= request.Price)
            .ToList();
        var expectedEquipments =
            TestMapper.Instance.Map<List<EquipmentDto>>(equipmentsFromDb);

        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        testDb.WaitForIndexing();
        //Assert
        result.Should().HaveSameCount(expectedEquipments);
        result.Should().BeEquivalentTo(expectedEquipments);
    }
    
    [Test]
    public async Task Handle_Type_ShouldReturnEquipmentsDtoListWithGivenType() {
        // Arrange
        using var testDb = new RavenTestDb();
        var seededEquipments = new List<EquipmentEntity> {
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "Test",
                Type = "Test type A",
                Price = 1
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "Test type A",
                Price = 2
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "TestB",
                Type = "Test type",
                Price = 3
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATestB",
                Type = "Test type",
                Price = 4
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "AB",
                Type = "Test type",
                Price = 5
            },
        };
        var request = new GetEquipmentsQuery();
        request.Type = "Test type A";
        var handler = new GetEquipmentsQueryHandler(testDb, TestMapper.Instance);
        
        using var session = testDb.Store.OpenSession();
        foreach (var equipment in seededEquipments) {
            session.Store(equipment); 
        }
        session.SaveChanges();
        
        var equipmentsFromDb = session
            .Query<EquipmentEntity>()
            .Where(a => a.Type == request.Type)
            .ToList();
        var expectedEquipments = TestMapper.Instance.Map<List<EquipmentDto>>(equipmentsFromDb);

        // Act
        testDb.WaitForIndexing();
        var result = await handler.Handle(request, CancellationToken.None);
        //Assert
        result.Should().HaveSameCount(expectedEquipments);
        result.Should().BeEquivalentTo(expectedEquipments);
    }
    [Test]
    public async Task Handle_AllFilters_ShouldReturnEquipmentsDtoListWithGivenConditions() {
        // Arrange
        using var testDb = new RavenTestDb();
        var seededEquipments = new List<EquipmentEntity> {
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "Test",
                Type = "Test type",
                Price = 1
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "c",
                Price = 2
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "Test type A",
                Price = 3
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "ATest",
                Type = "Test type",
                Price = 4
            },
            new() {
                Id = Guid.NewGuid().ToString(),
                Name = "AB",
                Type = "Test type",
                Price = 5
            }
        };
        var request = new GetEquipmentsQuery {
            Name = "ATest",
            Price = 2,
            Type = "ATest"
        };
        var handler = new GetEquipmentsQueryHandler(testDb, TestMapper.Instance);
        
        using var session = testDb.Store.OpenSession();
        foreach (var equipment in seededEquipments) {
            session.Store(equipment); 
        }
        session.SaveChanges();
        
        var equipmentsFromDb = session
            .Query<EquipmentEntity>()
            .Search(a => a.Name, $"*{request.Name}*" )
            .Where(a => a.Type == request.Type && a.Price <= request.Price )
            .ToList();
        var expectedEquipments = TestMapper.Instance.Map<List<EquipmentDto>>(equipmentsFromDb);

        // Act
        testDb.WaitForIndexing();
        var result = await handler.Handle(request, CancellationToken.None);
        //Assert
        result.Should().HaveSameCount(expectedEquipments);
        result.Should().BeEquivalentTo(expectedEquipments);
    }
}
