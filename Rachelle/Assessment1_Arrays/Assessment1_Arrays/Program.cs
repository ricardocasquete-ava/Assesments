namespace Assessment1_Arrays
{
    class Program
    {
        static void Main()
        {
            IMyArray myArray = new MyArray();            
            int number = new Random((int)DateTime.Now.Ticks).Next(1, 100);            
            var array = Enumerable.Range(1, 100).ToList().Where(x => !x.Equals(number));
            array = Util.Shuffle(array, new Random());
            Console.WriteLine($"{string.Join(", ", array.ToList().Select(x => $"{x}"))}");
            Console.WriteLine($"{string.Join(Environment.NewLine, myArray.GetArray(array).Select((x) => $"Missing number from the list is : {x}"))}");
            Console.WriteLine($"{string.Join(Environment.NewLine, myArray.GetSortedArray(array).Select((x) => $"Missing number from sorted list is : {x}"))}");
            
        }
    }    
}