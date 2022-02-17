using Xunit;

namespace Assessment_Arrays.Test
{
    public class UnitTest1
    {
       
        [Fact]
        public void TestSorted()
        {
            PopulateArray populateArray = new PopulateArray();
            int testExcl = 10;
            int[] newArray = populateArray.MakeArray(testExcl);
            Assert.Equal(testExcl, ArrayUtils.getNumberSorted(newArray));
        }

        [Fact]
        public void TestUnsorted()
        {
            PopulateArray populateArray = new PopulateArray();
            int testExcl = 30;
            int[] newArray = populateArray.MakeArray(testExcl);
            PopulateArray.Shuffle(newArray);

            Assert.Equal(testExcl, ArrayUtils.getNumberUnsorted(newArray));
        }
    }
}