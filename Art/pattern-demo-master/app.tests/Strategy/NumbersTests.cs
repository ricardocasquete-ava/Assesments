using System;
using App.Strategy;
using App.Strategy.Sorters;
using App.Strategy.Sorters.Implementations;
using Xunit;
using Xunit.Sdk;
using FluentAssertions;

namespace App.Tests.Strategy;

public class NumbersTests
{
    [Theory]
    [InlineData(typeof(BubbleSort), "BubbleSort")]
    [InlineData(typeof(LinqOrderBySort), "LinqOrderBy")]
    [InlineData(typeof(InsertionSort), "InsertionSort")]
    public void Strategy_Should_Allow_Classes_To_Use_Different_Implementations_Without_Code_Changes(Type sorterType, string expectedAlgorithm)
    {
        // ARRANGE
        var sorter = Activator.CreateInstance(sorterType) as ISorter;
        if (sorter is null) { throw new XunitException(); }

        // ACT
        var numbers = new Numbers(sorter);

        // ASSERT
        numbers.SortingAlgorithm.Should().Be(expectedAlgorithm);
        for(var i = 0; i < numbers.SortedItems.Length; i++)
        {
            numbers.SortedItems[i].Should().Be(i);
        }
    }

    [Fact]
    public void Strategy_Should_Allow_Classes_To_Behave_Differently_Depending_On_The_Implementation_Used()
    {
        // ARRANGE
        var sorter = new ReverseBubbleSort();

        // ACT
        var numbers = new Numbers(sorter);

        // ASSERT
        numbers.SortingAlgorithm.Should().Be("ReverseBubbleSort");
        var lastIndex = numbers.OriginalItems.Length - 1;
        for(var i = 0; i < numbers.SortedItems.Length; i++)
        {
            var expected = lastIndex - i;
            numbers.SortedItems[i].Should().Be(expected);
        }
    }
}