namespace Assessment1.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 100, 44)]
    public void Test1(int min, int max, int remove)
    {
        ISample mSample = new Sample();
        IEnumerable<int> mResult = mSample.Function(Enumerable.Range(min, max).ToList().Where(s => !s.Equals(remove)));
        Assert.Equal(2, mResult.Count());
        Assert.Equal(remove, mResult.FirstOrDefault());
        Assert.Equal(remove, mResult.LastOrDefault());
    }
}