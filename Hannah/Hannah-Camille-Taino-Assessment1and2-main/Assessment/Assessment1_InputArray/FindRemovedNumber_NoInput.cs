using System;

namespace Assessment.Assessment1_InputArray
{
    public class FindRemovedNumber_NoInput
    {
        static void FindTheRemovedNumber(string[] args)
        {
            int arraySum, removedNumber;
            //array removed number is 99
            int[] arrayRange = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
            21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,
            51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,
            81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,100 };

            arraySum = (arrayRange.Length + 1) * (arrayRange.Length + 2)/ 2;

            //compute the missing number
            foreach(int arrayLoopCount in arrayRange)
            {
                arraySum = arraySum - arrayLoopCount;
            }
                removedNumber = arraySum;

            Console.WriteLine("The removed number from this array range is: " + removedNumber);
        }
    }
}
