using Xunit;

namespace Assessment_Rover.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rover rover = new Rover();

            Assert.Equal("1 3 N", rover.MoveRover(5, 5, 1, 2, 'N', "LMLMLMLMM"));
        }

        [Fact]
        public void Test2()
        {
            Rover rover = new Rover();

            Assert.Equal("5 1 E", rover.MoveRover(5, 5, 3, 3, 'E', "MMRMMRMRRM"));
        }
    }
}