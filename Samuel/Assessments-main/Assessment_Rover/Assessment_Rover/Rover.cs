using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Rover
{
    public class Rover
    {
        public char steerLeft(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N':
                    currentDirection = 'W';
                    break;
                case 'S':
                    currentDirection = 'E';
                    break;
                case 'E':
                    currentDirection = 'N';
                    break;
                case 'W':
                    currentDirection = 'S';
                    break;
            }
            return currentDirection;
        }

        public char steerRight(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N':
                    currentDirection = 'E';
                    break;
                case 'S':
                    currentDirection = 'W';
                    break;
                case 'E':
                    currentDirection = 'S';
                    break;
                case 'W':
                    currentDirection = 'N';
                    break;
            }
            return currentDirection;
        }

        public String MoveRover(int upperBoundX, int upperBoundY, int currentX, int currentY, char currentDirection, String movement)
        {
            foreach (char c in movement)
            {

                if (c == 'L')
                {
                    currentDirection = steerLeft(currentDirection);
                }
                else if (c == 'R')
                {
                    currentDirection = steerRight(currentDirection);
                }
                else if (c == 'M')
                {
                    switch (currentDirection)
                    {
                        case 'N':
                            if (currentY != upperBoundY)
                            {
                                currentY++;
                            }
                            else
                            {
                                Console.WriteLine("Tried to go beyond the field. Invalid move!");
                            }
                            break;
                        case 'S':
                            if (currentY != 0)
                            {
                                currentY -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Tried to go beyond the field. Invalid move!");
                            }
                            break;
                        case 'E':
                            if (currentX != upperBoundX)
                            {
                                currentX++;
                            }
                            else
                            {
                                Console.WriteLine("Tried to go beyond the field. Invalid move!");
                            }
                            break;
                        case 'W':
                            if (currentX != 0)
                            {
                                currentX -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Tried to go beyond the field. Invalid move!");
                            }
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Must be a string of L, R, and M.");
                }
            }
            Console.WriteLine(currentX + " " + currentY + " " + currentDirection);

            return currentX.ToString() + " " + currentY.ToString() + " " + currentDirection.ToString();
        }   
    }
}
