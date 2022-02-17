namespace App.Strategy;

public interface ISorter
{
    string Algorithim { get; }
    int[] Sort(params int[] values);
}