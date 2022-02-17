namespace GapFinder;

public static class Incrementers
{
    /// <summary>
    ///     Defines the logic for incrementing items by 1.
    /// </summary>
    /// <param name="i">The index of the item</param>
    /// <returns>The value of the item</returns>
    public static int IncrementByOne(int i) => i;

    /// <summary>
    ///     Defines the logic for incrementing items by 1, but the sequence starts with 1.
    /// </summary>
    /// <param name="i">The index of the item</param>
    /// <returns>The value of the item</returns>
    public static int IncrementByOneButStartWithOne(int i) => i + 1;
}