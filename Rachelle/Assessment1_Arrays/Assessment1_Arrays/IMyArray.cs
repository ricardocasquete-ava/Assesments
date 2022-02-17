namespace Assessment1_Arrays
{
    public interface IMyArray
    {
        IEnumerable<int> GetSortedArray(IEnumerable<int> array);

        IEnumerable<int> GetArray(IEnumerable<int> array);
    }
}
