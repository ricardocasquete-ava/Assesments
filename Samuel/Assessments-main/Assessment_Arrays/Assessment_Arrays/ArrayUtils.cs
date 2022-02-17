namespace Assessment_Arrays
{
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
                for(i = 0; i < 99; i++)
                {

                    if(array[i] == j)
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
}
