using System.Linq;
using App.Factory;
using App.Factory.Animals;
using Xunit;
using FluentAssertions;

namespace App.Tests.Factory;

public class AnimalFinderTests
{
    private readonly AnimalFinder _finder;

    public AnimalFinderTests()
    {
        _finder = new AnimalFinder();
    }

    [Theory]
    [InlineData("Dog", "Arf! Arf!", Attributes.CanSwim, Attributes.CanWalk, Attributes.EatsMeat, Attributes.EatsVeggies)]
    [InlineData("Duck", "Quack! Quack!", Attributes.CanSwim, Attributes.CanWalk, Attributes.CanFly, Attributes.EatsVeggies)]
    [InlineData("Eagle", "Screech!", Attributes.CanFly, Attributes.EatsMeat)]
    public void Factory_Should_Encapsulate_Logic_For_Instantiating_Specific_Objects(string name, string sound, params Attributes[] attributes)
    {
        // ACT
        var results = _finder.FindAnimals(attributes);

        // ASSERT
        results.Should().HaveCount(1);
        var actual = results[0];
        actual.Name.Should().Be(name);
        actual.MakeSound().Should().Be(sound);
    }

    [Fact]
    public void Factory_Should_Manage_The_Creation_Of_The_Required_Objects()
    {
        // ARRANGE
        var attributes1 = new [] {
            Attributes.CanSwim,
            Attributes.EatsMeat
        };

        var attributes2 = new [] {
            Attributes.EatsMeat
        };

        // ACT
        var swimsAndEatsMeat = _finder.FindAnimals(attributes1);
        var eatsMeat = _finder.FindAnimals(attributes2);

        // ASSERT
        var shark1 = swimsAndEatsMeat.Single(a => a.Name == "Shark");
        var shark2 = eatsMeat.Single(a => a.Name == "Shark");
        shark1.Should().NotBeSameAs(shark2);
    }
}