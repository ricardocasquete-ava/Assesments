using Singleton.Patterns;

class Program
{
     static void Main()
    {
        LazySingleton<String> lazySingleton = new(() => "Lazy");
        Console.WriteLine(lazySingleton.Instance?.ToString() ?? "Lazy-not");

        NoThreadSafeSingleton<String> noThreadSafeSingleton = new(() => "NoThreadSafe");
        Console.WriteLine(noThreadSafeSingleton.Instance?.ToString() ?? "NoThreadSafe-not");

        ThreadSafeSingleton<String> threadSafeSingleton = new(() => "ThreadSafe");
        Console.WriteLine(threadSafeSingleton.Instance?.ToString() ?? "ThreadSafe-not");
    }
}
