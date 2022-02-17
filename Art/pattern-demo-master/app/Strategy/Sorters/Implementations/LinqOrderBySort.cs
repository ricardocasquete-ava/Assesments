namespace App.Strategy.Sorters.Implementations;

public class LinqOrderBySort : ISorter
{
    public string Algorithim => "LinqOrderBy";

    public int[] Sort(params int[] values)
    {
        var sorted = values.OrderBy(x => x);

        return sorted.ToArray();
    }
}