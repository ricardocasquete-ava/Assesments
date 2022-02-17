namespace Assessment_Arrays
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
}
