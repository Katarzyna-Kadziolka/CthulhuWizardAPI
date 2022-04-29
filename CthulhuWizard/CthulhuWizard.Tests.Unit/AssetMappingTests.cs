using System.Linq;
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit;

public class AssetMappingTests {
    private static IMapper _mapper;
    public AssetMappingTests() {
        var mappingConfig = new MapperConfiguration(mc
            => {
            mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
        });
        _mapper = mappingConfig.CreateMapper();
    }

    [Test]
    public void Map_Asset_ShouldReturnAssetDto() {
        // Arrange
        var asset = AssetGenerator.Asset;
        // Act
        var assetDto = _mapper.Map<AssetDto>(asset);
        // Assert
        assetDto.Assets.Should().Be(asset.Assets);
        assetDto.Cash.Should().Be(asset.Cash);
        assetDto.SpendingLevel.Should().Be(asset.SpendingLevel);
    }
}