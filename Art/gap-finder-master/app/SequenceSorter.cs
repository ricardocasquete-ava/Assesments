namespace GapFinder;

public static class SequenceSorter
{
    /// <summary>
    ///     Sorts a sequence of items in ascending order. Uses insertion sort.
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public static int[] Sort(int[] sequence)
    {
        var lower = new Stack<int>();
        var upper = new Stack<int>();

        foreach(var item in sequence)
        {
            EvaluateOrder(lower, upper, item);
        }

        return ToArray(lower, upper);
    }

    private static void EvaluateOrder(Stack<int> lower, Stack<int> upper, int item)
    {
        // traverse the upper group and transfer values less than the item to the lower group
        while(upper.Count > 0 && item > upper.Peek())
        {
            lower.Push(upper.Pop());
        }

        // traverse the lower group and transfer values greater than the item to the upper group
        while(lower.Count > 0 && lower.Peek() > item)
        {
            upper.Push(lower.Pop());
        }

        // at this point all the items in the lower group are less than the item
        //   and all items in the upper group are greater than the item
        //   so inserting it on either group doesn't matter
        lower.Push(item);
    }

    private static int[] ToArray(Stack<int> lower, Stack<int> upper)
    {
        while(lower.Count > 0)
        {
            upper.Push(lower.Pop());
        }

        return upper.ToArray();
    }
}