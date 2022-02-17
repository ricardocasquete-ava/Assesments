namespace Assessment1_Arrays
{
    public class MyArray : IMyArray
    {
        public IEnumerable<int> GetArray(IEnumerable<int> array)
        {
            return Enumerable.Range(1, 100).Except(array);
        }

        public IEnumerable<int> GetSortedArray(IEnumerable<int> array)
        {
            return Enumerable.Range(1, 100).Except(array.OrderBy(x => x));
        }
    }
}
