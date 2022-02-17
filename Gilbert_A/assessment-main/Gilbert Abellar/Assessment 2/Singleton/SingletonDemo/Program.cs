namespace Singleton;

class Program
{
    static void Main()
    {
        Console.Clear();

        SingletonLazy<Model> mSingletonLazy = new(() => new Model());
        Console.WriteLine(mSingletonLazy.Instance?.ToString() ?? string.Empty);

        SingletonNoThreadSafe<Model> mSingletonNoThreadSafe = new(() => new Model());
        Console.WriteLine(mSingletonLazy.Instance?.ToString() ?? string.Empty);

        SingletonThreadSafe<Model> mSingletonThreadSafe = new(() => new Model());
        Console.WriteLine(mSingletonThreadSafe.Instance?.ToString() ?? string.Empty);

        Console.WriteLine();
    }
}