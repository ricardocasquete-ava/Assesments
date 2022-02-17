namespace GapFinder;

public static class SequenceGenerator
{
    /// <summary>
    ///     Generates a sequence of number.
    /// </summary>
    /// <param name="count">The number of items in the sequence.</param>
    /// <param name="increment">The increment used by each item in the sequence to determine their value. The function takes the index of the item and returns the value in that index.</param>
    /// <returns></returns>
    public static int[] Generate(int count, Func<int, int> increment)
    {
        if (count <= 0) { return new int[0]; }

        var output = new List<int>();
        for(var i = 0; i < count; i++)
        {
            var currentNumber = increment(i);
            output.Add(currentNumber);
        }

        return output.ToArray();
    }

    /// <summary>
    ///     Randomises the order of the items in the sequence.
    /// </summary>
    /// <param name="sequence">The sequence of items to randomise.</param>
    /// <returns></returns>
    public static int[] Randomise(params int[] sequence)
    {
        if (sequence.Length <= 0) { return new int[0]; }

        var random = new Random(Guid.NewGuid().GetHashCode());
        var newSequence = new List<int>();
        newSequence.Add(sequence[0]);
        for(var i = 1; i < sequence.Length; i++)
        {
            var randomIndex = random.Next(0, i + 1);
            newSequence.Insert(randomIndex, sequence[i]);
        }

        return newSequence.ToArray();
    }
}