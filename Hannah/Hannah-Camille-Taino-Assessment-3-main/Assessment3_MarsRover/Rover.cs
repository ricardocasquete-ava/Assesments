
namespace Assessment3_MarsRover
{
    public class Rover
    {
        private int xcoordinates;
        private int ycoordinates;
        private char direction;

        public Rover(int xcoordinates, int ycoordinates, char direction)
        {
            this.xcoordinates = xcoordinates;
            this.ycoordinates = ycoordinates;
            this.direction = direction;
        }

        public int getXcoord()
        {
            return xcoordinates;
        }

        public int getYcoord()
        {
            return ycoordinates;
        }

        public char getDirection()
        {
            return direction;
        }

        public void setXcoord(int xcoordinates)
        {
            this.xcoordinates = xcoordinates;
        }

        public void setYcoord(int ycoordinates)
        {
            this.ycoordinates = ycoordinates;
        }

        public void setDirection(char direction)
        {
            this.direction = direction;
        }

        public void spinLeft()
        {
            char currentDirection = getDirection();
            switch (currentDirection)
            {
                case 'N':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'W')))
                        setDirection('W');
                    break;
                case 'W':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'S')))

                        setDirection('S');
                    break;
                case 'S':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'E')))

                        setDirection('E');
                    break;
                case 'E':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'N')))

                        setDirection('N');
                    break;
            }
        }

        public void spinRight()
        {
            char currentDirection = getDirection();
            switch (currentDirection)
            {
                case 'N':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'E')))
                        setDirection('E');
                    break;
                case 'W':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'N')))
                        setDirection('N');
                    break;
                case 'S':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'W')))
                        setDirection('W');
                    break;
                case 'E':
                    if (!(MarsHelper.checkCollision(xcoordinates, ycoordinates, 'S')))
                        setDirection('S');
                    break;
            }
        }

        public void advance()
        {
            char currentDirection = getDirection();
            switch (currentDirection)
            {
                case 'N':
                    if ((ycoordinates + 1 <= Plateau.getMaxy()) && (ycoordinates + 1 >= 0) && (!(MarsHelper.checkCollision(xcoordinates, ycoordinates + 1, direction))))
                        ycoordinates = ycoordinates + 1;

                    break;
                case 'W':
                    if ((xcoordinates - 1 <= Plateau.getMaxx()) && (xcoordinates - 1 >= 0) && (!(MarsHelper.checkCollision(xcoordinates - 1, ycoordinates, direction))))
                        xcoordinates = xcoordinates - 1;
                    break;
                case 'E':
                    if ((xcoordinates + 1 <= Plateau.getMaxx()) && (xcoordinates + 1 >= 0) && (!(MarsHelper.checkCollision(xcoordinates + 1, ycoordinates, direction))))
                        xcoordinates = xcoordinates + 1;
                    break;
                case 'S':
                    if ((ycoordinates - 1 <= Plateau.getMaxy()) && (ycoordinates - 1 >= 0) && (!(MarsHelper.checkCollision(xcoordinates, ycoordinates - 1, direction))))

                        ycoordinates = ycoordinates - 1;
                    break;

            }

        }
    }
}