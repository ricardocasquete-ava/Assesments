namespace Assessment_Arrays
{
    class Program
    {
        

        static void Main()
        {
            PopulateArray populateArray = new PopulateArray();

            Random randomNumber = new Random();

            int excluded = randomNumber.Next(1, 101);
            Console.WriteLine("Excluded number: " + excluded);
            Console.ReadLine();

            Console.WriteLine("Generating sorted array...");
            int[] newArray = populateArray.MakeArray(excluded);

            Console.WriteLine("Missing number found from sorted array: " + ArrayUtils.getNumberSorted(newArray));

            Console.WriteLine("Shuffling array...");
            PopulateArray.Shuffle(newArray);

            Console.WriteLine("Missing number found from unsorted array: "+ArrayUtils.getNumberUnsorted(newArray));

        }
    }
}

