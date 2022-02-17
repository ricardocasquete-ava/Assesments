namespace Singleton;

[ClassInterface(ClassInterfaceType.None)]
public sealed class SingletonLazy<T> : MarshalByRefObject
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Lazy<T?> mInstance;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Func<T> mImplementation;

    public SingletonLazy(Func<T> implementation)
    {
        ArgumentNullException.ThrowIfNull(implementation);
        mImplementation = implementation;
        mInstance = new Lazy<T?>(() => mImplementation.Invoke());
    }

    public sealed override string ToString() => (mImplementation?.GetType().Name ?? base.ToString());

    public T? Instance => mInstance.Value;
}