using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assessment_Arrays.Test
{

    public class PopulateArray
    {
        public int[] MakeArray(int exclusion)
        {
            int[] newArray = new int[99]; // a list from 1 to 100 excl. one number will always be 99
            int i = 0; // for index counting
            int j = 1; // for storing the numbers
            do
            {
                if (j != exclusion) // stores the numbers
                {
                    newArray[i] = j;
                    //Console.WriteLine(newArray[i]);
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }


            } while (i != 99);

            /*for (int k = 0; k < 99; k++)
            {
                Console.WriteLine("Number in index" + k + " is: " + newArray[k]);
            }*/
            return newArray;
        }

        public static void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

    public class ArrayUtils
    {
        public static int getNumberUnsorted(int[] array) // time complexity: O(n^2)
        {
            int missingNum = -1;

            int i;
            int j = 1;
            int isFound;
            do
            {
                isFound = -1;
                for (i = 0; i < 99; i++)
                {

                    if (array[i] == j)
                    {
                        isFound = 1;

                    }

                }
                if (isFound == -1)
                {
                    missingNum = j;

                }
                j++;
            } while (missingNum == -1);

            return missingNum;
        }

        public static int getNumberSorted(int[] array) // time complexity: O(n)
        {
            int missingNum = -1;

            int i;
            int j = 1;
            int isFound;
            do
            {
                isFound = -1;
                for (i = 0; i < 99; i++)
                {
                    //Console.WriteLine("array[i] is : " + array[i] + " -- j is: " + j);
                    if (array[i] != j)
                    {
                        isFound = 1;
                        missingNum = j;
                        //Console.WriteLine("Found missing number: " + j);
                        break;
                    }
                    j++;
                }

            } while (missingNum == -1);

            return missingNum;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSorted()
        {
            PopulateArray populateArray = new PopulateArray();
            int testExcl = 10;
            int[] newArray = populateArray.MakeArray(testExcl);
            Assert.Equals(testExcl, ArrayUtils.getNumberSorted(newArray));
        }

        public void TestUnsorted()
        {
            PopulateArray populateArray = new PopulateArray();
            int testExcl = 30;
            int[] newArray = populateArray.MakeArray(testExcl);
            PopulateArray.Shuffle(newArray);

            Assert.Equals(testExcl, ArrayUtils.getNumberUnsorted(newArray));
        }
    }
}
