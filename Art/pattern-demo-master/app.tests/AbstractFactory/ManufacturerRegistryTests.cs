using App.AbstractFactory;
using App.AbstractFactory.Manufacturers;
using Xunit;
using FluentAssertions;

namespace App.Tests.AbstractFactory;

public class ManufacturerRegistryTests
{
    private readonly ManufacturerRegistry _registry;

    public ManufacturerRegistryTests()
    {
        _registry = new ManufacturerRegistry();
    }

    [Theory]
    [InlineData(ManufacturerType.Green, "Green Co")]
    [InlineData(ManufacturerType.HighEnd, "Boutique Sports Cars")]
    [InlineData(ManufacturerType.Hybrid, "Modern Company")]
    [InlineData(ManufacturerType.MassProduced, "Family Cars")]
    public void AbstractFactory_Should_Encapsulate_Logic_For_Instantiating_Specific_Factories(ManufacturerType type, string expectedName)
    {
        // ACT
        var manufacturer = _registry.GetManufacturer(type);

        // ASSERT
        manufacturer.Name.Should().Be(expectedName);
    }

    [Theory]
    [InlineData(ManufacturerType.Green, "Sedan", "Electric", "Leather", "Radio", "Green")]
    [InlineData(ManufacturerType.HighEnd, "StationWagon", "Gasoline", "Leather", "DashCam", "Radio", "RearCam", "HighEnd")]
    [InlineData(ManufacturerType.Hybrid, "StationWagon", "Hybrid", "FauxLeather", "DashCam", "Radio", "RearCam", "Hybrid")]
    [InlineData(ManufacturerType.MassProduced, "StationWagon", "Diesel", "FauxLeather", "Radio", "RearCam")]
    public void Factory_Returned_By_AbstractFactory_Should_Handle_Its_Own_Logic_For_Instantiating_Required_Objects(ManufacturerType type, string expectedBody, string expectedEngine, string expectedSeat, params string[] expectedAddons)
    {
        // ARRANGE
        var manufacturer = _registry.GetManufacturer(type);
        var tier = TierLevel.Standard;

        // ACT
        var car = manufacturer.AssembleCar(tier);

        // ASSERT
        car.Body.Should().Be(expectedBody);
        car.Engine.Should().Be(expectedEngine);
        car.Seat.Should().Be(expectedSeat);
        car.Addons.Should().BeEquivalentTo(expectedAddons);
    }
}