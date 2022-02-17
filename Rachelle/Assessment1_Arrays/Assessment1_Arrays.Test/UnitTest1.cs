using System.Linq;
using Xunit;

namespace Assessment1_Arrays.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 100, 6)]
        public void TestSorted(int min, int max, int toRemove)
        {
            IMyArray myArray = new MyArray();
            var result = myArray.GetSortedArray(Enumerable.Range(min, max).ToList().Where(x => !x.Equals(toRemove)));
            Assert.Equal(toRemove, result.FirstOrDefault());
        }

        [Theory]
        [InlineData(1, 100, 16)]
        public void TestArray(int min, int max, int toRemove)
        {
            IMyArray myArray = new MyArray();
            var result = myArray.GetArray(Enumerable.Range(min, max).ToList().Where(x => !x.Equals(toRemove)));
            Assert.Equal(toRemove, result.FirstOrDefault());
        }
    }
}