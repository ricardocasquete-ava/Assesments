namespace Assessment_Rover
{
    class Program
    {
        static void Main(string[] args)
        {

            int upperBoundX = 5;
            int upperBoundY = 5;
            int currentX = 1;
            int currentY = 2;
            char currentDirection = 'N';
            String movement = "LMLMLMLMM";

            Rover rover = new Rover();
            rover.MoveRover(upperBoundX, upperBoundY, currentX, currentY, currentDirection, movement);

            upperBoundX = 5;
            upperBoundY = 5;
            currentX = 3;
            currentY = 3;
            currentDirection = 'E';
            movement = "MMRMMRMRRM";

            rover.MoveRover(upperBoundX, upperBoundY, currentX, currentY, currentDirection, movement);

        }

    }


}