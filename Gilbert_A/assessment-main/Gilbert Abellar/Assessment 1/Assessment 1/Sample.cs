namespace Assessment_1;

public class Sample : ISample
{
    public IEnumerable<int> Function(IEnumerable<int> array)
    {
        return new int[]
        {
            Enumerable.Range(1, 100).Except(array.OrderBy(s => s)).FirstOrDefault(),
            Enumerable.Range(1, 100).Except(array).FirstOrDefault()
        };
    }
}