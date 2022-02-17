using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GapFinder;
using Xunit;
using FluentAssertions;

namespace GapFinder.Tests;

public class SequenceScannerTests
{
    [Theory]
    [InlineData(new [] {1, 2, 3, 4, 5, 6, 7}, 0)]
    [InlineData(new [] {0, 2, 3, 4, 5, 6, 7}, 1)]
    [InlineData(new [] {0, 1, 3, 4, 5, 6, 7}, 2)]
    [InlineData(new [] {0, 1, 2, 4, 5, 6, 7}, 3)]
    [InlineData(new [] {0, 1, 2, 3, 5, 6, 7}, 4)]
    [InlineData(new [] {0, 1, 2, 3, 4, 6, 7}, 5)]
    [InlineData(new [] {0, 1, 2, 3, 4, 5, 7}, 6)]
    [InlineData(new [] {0, 1, 2, 3, 4, 5, 6}, 7)]
    [InlineData(new [] {1, 2, 3, 4, 5}, 0)]
    [InlineData(new [] {0, 2, 3, 4, 5}, 1)]
    [InlineData(new [] {0, 1, 3, 4, 5}, 2)]
    [InlineData(new [] {0, 1, 2, 4, 5}, 3)]
    [InlineData(new [] {0, 1, 2, 3, 5}, 4)]
    [InlineData(new [] {0, 1, 2, 3, 4}, 5)]
    [InlineData(new [] {1, 2, 3, 4}, 0)]
    [InlineData(new [] {0, 2, 3, 4}, 1)]
    [InlineData(new [] {0, 1, 3, 4}, 2)]
    [InlineData(new [] {0, 1, 2, 4}, 3)]
    [InlineData(new [] {0, 1, 2, 3}, 4)]
    [InlineData(new [] {1, 2, 3}, 0)]
    [InlineData(new [] {0, 2, 3}, 1)]
    [InlineData(new [] {0, 1, 3}, 2)]
    [InlineData(new [] {0, 1, 2}, 3)]
    [InlineData(new [] {1, 2}, 0)]
    [InlineData(new [] {0, 2}, 1)]
    [InlineData(new [] {0, 1}, 2)]
    public void FindMissingNumber_Should_Return_Correctly(int[] sequence, int missingNumber)
    {
        // ACT
        var actual = SequenceScanner.FindMissingNumber(sequence, Incrementers.IncrementByOne, 2);

        // ASSERT
        actual.Should().Be(missingNumber);
    }

    [Theory]
    [InlineData("sample\\input-50-sequence-33-missing.txt", 33)]
    [InlineData("sample\\input-5000-sequence-1543-missing.txt", 1543)]
    [InlineData("sample\\input-random-100-sequence-9-missing.txt", 9)]
    [InlineData("sample\\input-random-10000-sequence-3489-missing.txt", 3489)]
    public void FindMissingNumber_Should_Return_Correctly_With_File_Input(string fileName, int missingNumber)
    {
        // ARRANGE
        var content = File.ReadAllText(fileName);
        var sequence = content?.Split(" ") ?? new string[0];
        var converted = sequence.Select(n => int.Parse(n)).ToArray();

        // ACT
        var actual = SequenceScanner.FindMissingNumber(converted, Incrementers.IncrementByOneButStartWithOne);

        // ASSERT
        actual.Should().Be(missingNumber);
    }

    [Theory]
    [InlineData(5000)]
    [InlineData(1000)]
    [InlineData(100)]
    [InlineData(10)]
    [InlineData(1)]
    public void FindMissingNumber_Should_Return_Correctly_Given_Varying_Group_Size(int groupSize)
    {
        // ARRANGE
        var expected = 3489;
        var content = File.ReadAllText("sample\\input-random-10000-sequence-3489-missing.txt");
        var sequence = content?.Split(" ") ?? new string[0];
        var converted = sequence.Select(n => int.Parse(n)).ToArray();

        // ACT
        var actual = SequenceScanner.FindMissingNumber(converted, Incrementers.IncrementByOneButStartWithOne, groupSize);

        // ASSERT
        actual.Should().Be(expected);
    }

    [Fact]
    public void FindMissingNumber_Should_Handle_Custom_Incrementer()
    {
        // ARRANGE
        var count = 100;
        var incrementer = (int x) => x * 2;

        var missingIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, count + 1);
        var expected = incrementer(missingIndex);

        var list = new List<int>();
        for(int i = 0; i < count; i++)
        {
            if (i == missingIndex) { continue; }
            list.Add(incrementer(i));
        }

        var sequence = list.ToArray();

        // ACT
        var actual = SequenceScanner.FindMissingNumber(sequence, incrementer);

        // ASSERT
        actual.Should().Be(expected);
    }
}