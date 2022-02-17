namespace Singleton.Patterns
{
    public sealed class ThreadSafeSingleton<T>
    {
        private T? _instance;       
        private readonly object _sync;        
        private readonly Func<T> _implementation;

        public ThreadSafeSingleton(Func<T> implementation)
        {
            ArgumentNullException.ThrowIfNull(implementation);
            _sync = new object();
            _implementation = implementation;
        }

        public sealed override string ToString()
        {
            return _implementation?.GetType().Name ?? base.ToString();
        }

        public T? Instance
        {
            get
            {
                if (_instance is not null) return _instance;
                lock (_sync) return (_instance ??= _implementation.Invoke());
            }
        }
    }
}
