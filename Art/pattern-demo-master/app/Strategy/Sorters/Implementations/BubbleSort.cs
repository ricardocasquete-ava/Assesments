namespace App.Strategy.Sorters.Implementations;

public class BubbleSort : ISorter
{
    public string Algorithim => "BubbleSort";

    public int[] Sort(params int[] values)
    {
        var sorted = values;

        for(var i = 0; i < sorted.Length; i++)
        {
            for(var j = i+1; j < sorted.Length; j++)
            {
                var first = sorted[i];
                var second = sorted[j];
                if (first > second)
                {
                    sorted[i] = second;
                    sorted[j] = first;
                }
            }
        }

        return sorted;
    }
}