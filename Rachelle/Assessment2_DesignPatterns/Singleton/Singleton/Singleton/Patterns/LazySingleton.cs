namespace Singleton.Patterns
{
    public sealed class LazySingleton<T>
    {        
        private readonly Lazy<T?> _instance;        
        private readonly Func<T> _implementation;

        public LazySingleton(Func<T> implementation)
        {
            ArgumentNullException.ThrowIfNull(implementation);
            _implementation = implementation;
            _instance = new Lazy<T?>(() => _implementation.Invoke());
        }

        public sealed override string ToString()
        {
            return _implementation?.GetType().Name ?? base.ToString();
        }

        public T? Instance => _instance.Value;
    }
}
