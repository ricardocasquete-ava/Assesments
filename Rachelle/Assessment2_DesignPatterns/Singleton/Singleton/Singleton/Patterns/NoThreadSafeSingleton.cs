namespace Singleton.Patterns
{
    public sealed class NoThreadSafeSingleton<T>
    {
        private T? _instance;        
        private readonly Func<T> _implementation;

        public NoThreadSafeSingleton(Func<T> implementation)
        {
            ArgumentNullException.ThrowIfNull(implementation);
            _implementation = implementation;
        }

        public sealed override string ToString()
        {
            return _implementation?.GetType().Name ?? base.ToString();
        }

        public T? Instance => (_instance ??= _implementation.Invoke());
    }
}
