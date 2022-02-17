namespace Assessment_1;

class Program
{
    static void Main()
    {
        ISample mSample = new Sample();
        int number = new Random((int)DateTime.Now.Ticks).Next(1, 100);
        Console.WriteLine($"{string.Join(Environment.NewLine, mSample.Function(Enumerable.Range(1, 100).ToList().Where(s => !s.Equals(number))).Select((s, i) => ((i == 0) ? $"Missing Number from Array (Sorted): {s}" : $"Missing Number from Array (Not Sorted): {s}")))}");
    }
}