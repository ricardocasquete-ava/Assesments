namespace App.Strategy;

/// <summary>
/// This class doesn't care for the actual implementation of ISorter.
/// The behaviour will be dictated by the actual implementation of the ISorter provided to it.
/// </summary>
public class Numbers
{
    private readonly ISorter _sorter;

    public Numbers(ISorter sorter)
    {
        _sorter = sorter;

        SortingAlgorithm = sorter.Algorithim;

        var items = Initialise(100);
        OriginalItems = items;
        SortedItems = _sorter.Sort(OriginalItems);
    }

    public string SortingAlgorithm { get; }

    public int[] OriginalItems { get; }
    public int[] SortedItems { get; }

    private int[] Initialise(int numberOfItems)
    {
        var randomiser = new Random(Guid.NewGuid().GetHashCode());
        var list = new List<int>();
        for(var i = 0; i < numberOfItems; i++)
        {
            var newIndex = randomiser.Next(0, i+1);
            list.Insert(newIndex, i);
        }

        return list.ToArray();
    }
}