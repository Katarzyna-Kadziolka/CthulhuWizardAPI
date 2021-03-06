using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class AssetMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_AssetEntity_ShouldReturnAssetDto() {
        // Arrange
        var generator = new AssetEntityGenerator();
        var asset = generator.Generate();
        // Act
        var assetDto = _mapper.Map<AssetDto>(asset);
        // Assert
        assetDto.Assets.Should().Be(asset.Assets);
        assetDto.Cash.Should().Be(asset.Cash);
        assetDto.SpendingLevel.Should().Be(asset.SpendingLevel);
    }
}