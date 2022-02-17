using System;
using System.Linq;

namespace Dizon.SelfAssessment._1
{
    class Program
    {
        public static bool tryAgain = true;

        public static void Main(string[] args)
        {
            MyArrayList();
        }

        public static bool BetweenRanges(int min, int max, int arrayList)
        {
            return (min <= arrayList && arrayList <= max);
        }

        public static void MyArrayList()
        {
            int i;
            int j = 5;
            int[] a = new int[5];
            bool inputNotValid = true;

            Random random = new Random();

            while (inputNotValid)
            {
                try
                {
                    Console.WriteLine("\nPlease input 5 elements to store in the ArrayList:");
                    for (i = 0; i < j; i++)
                    {
                        Console.Write("> ");
                        a[i] = int.Parse(Console.ReadLine());

                        //Check if the input number is in range
                        while (!BetweenRanges(1, 100, a[i]))
                        {
                            Console.WriteLine("\nInvalid input, enter a value between 1 to 100 only. Please try again.");
                            Console.Write("> ");
                            a[i] = int.Parse(Console.ReadLine());
                        }
                    }
                    inputNotValid = false;
                }
                catch
                {
                    Console.WriteLine("\nSorry, text is not allowed. Please try again.");
                }
            }

            //Remove random number from the given ArrayList
            int index = random.Next(a.Length);
            int randomNum = a[index];
            a = a.Except(new int[] { randomNum }).ToArray();

            //Sort ArrayList in Ascending Order
            Array.Sort(a);
            Console.WriteLine("\n\nSorted List after removing {0} from the ArrayList:", randomNum);
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            //Sort ArrayList in Random Position
            Console.WriteLine("\n\nUnsorted List after removing {0} from the ArrayList:", randomNum);
            a = a.OrderBy(x => random.Next()).ToArray();
            foreach (var k in a)
            {
                Console.Write(k + " ");
            }

            Console.WriteLine("\n\nWould you like to try again [Y/N]?");
            string t = Console.ReadLine();

            if (t == "Y" || t == "y")
            {
                MyArrayList();
            }
            else if (t == "N" || t == "n")
            {
                tryAgain = false;
            }
            else
            {
                Console.WriteLine("\nInvalid Input.");
                tryAgain = false;
            }
        }
    }
}
