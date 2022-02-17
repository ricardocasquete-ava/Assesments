using System;

namespace Assessment
{
    public class FindRemovedNumber
    {
        static void Main()
        {
            int arrayLoopCount, arrayInputRange, arraySum = 0, removedNumber;

            Console.WriteLine("Enter the count/range of an array: ");
            string enteredArrayRange = Console.ReadLine();
            arrayInputRange = Int32.Parse(enteredArrayRange);
            if (arrayInputRange <= 100)
            {
                int[] arrayRange = new int[arrayInputRange - 1];
                Console.WriteLine("Enter the sorted or unsorted array: ");
                for (arrayLoopCount = 0; arrayLoopCount < arrayInputRange - 1; arrayLoopCount++)
                {
                    arrayRange[arrayLoopCount] = Convert.ToInt32(Console.ReadLine());
                    arraySum = arraySum + arrayRange[arrayLoopCount];
                }
                removedNumber = (arrayInputRange * (arrayInputRange + 1)) / 2 - arraySum;
                Console.WriteLine("The removed number from this array range is: " + removedNumber);
            }
            else
            {
                Console.WriteLine("Please enter 1-100 array range Only");
            }
        }
    }
}