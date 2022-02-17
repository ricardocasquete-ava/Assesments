namespace GapFinder;

public static class SequenceScanner
{
    private const int GROUP_SIZE = 1000;

    /// <summary>
    ///     Finds the missing number from the sequence given it's increment function.
    /// </summary>
    /// <param name="sequence">The sequence to scan.</param>
    /// <param name="increment">The increment used by each item in the sequence to determine their value. The function takes the index of the item and returns the value in that index.</param>
    /// <param name="groupSize">The minimum size of the group when scanning the sequence in batches.</param>
    /// <returns></returns>
    public static int FindMissingNumber(int[] sequence, Func<int, int> increment, int groupSize = GROUP_SIZE)
    {
        if (groupSize <= 0) { throw new ArgumentOutOfRangeException("Value should be greater than 0.", nameof(groupSize)); }

        var sorted = SequenceSorter.Sort(sequence);
        var jobs = new Queue<Tuple<int, int>>();

        // the first group will contain the entire sequence
        var rangeStartIndex = 0;
        var rangeCount = sorted.Length;

        if (groupSize > 1)
        {
            // only divide the group further if necessary
            jobs.Enqueue(new Tuple<int, int>(rangeStartIndex, rangeCount));
        }

        // progressively decrease the items to scan
        //      by dividing the sequence into 2 and focusing on the half which is not in order.
        // order is determined by testing the mid point and seeing if its value is as expected
        //      given its position (index) in the sequence and the increment function.
        // if the midpoint is as expected, then the numbers after it must contain the missing number,
        //      otherwise, it's on the numbers before it.
        while(jobs.Count != 0)
        {
            var job = jobs.Dequeue();

            // if the group exceeds the bounds of the original sequence stop further division
            if (job.Item1 >= sorted.Length ||job.Item2 <= 0) { continue; }

            var startIndex = rangeStartIndex = job.Item1;
            var count = rangeCount = job.Item2;
            if (count <= groupSize || count <= 2) { continue; }

            // get the mid point of the group
            var midCount = count == 2 ? 0 : (count / 2);
            var midIndex = startIndex + midCount;
            var expectedValue = increment(midIndex);
            var actualValue = sorted[midIndex];

            var nextStartIndex = -1;
            var nextCount = -1;

            if (actualValue == expectedValue)
            {
                // value is as expected which means the values at this point are in the right order
                // so look from the mid point to the remainder of the group
                nextStartIndex = midIndex + 1;
                nextCount = count - nextStartIndex;
            }
            else
            {
                // value is not as expected which means a values before this point is missing
                // so look from the start of the group to the mid point
                nextStartIndex = startIndex;
                nextCount = midIndex - startIndex;
            }

            // scan this new group
            jobs.Enqueue(new Tuple<int, int>(nextStartIndex, nextCount));
        }

        // work with the last group identified from the previous process
        // this should have considerably reduced items to scan
        for(var i = 0; i < rangeCount; i++)
        {
            var actualIndex = i + rangeStartIndex;
            var item = sorted[actualIndex];
            var expected = increment(actualIndex);
            if (item != expected) { return expected; }
        }

        // the group appears to be in order so the missing item is the next one
        return increment(rangeStartIndex + rangeCount);
    }
}