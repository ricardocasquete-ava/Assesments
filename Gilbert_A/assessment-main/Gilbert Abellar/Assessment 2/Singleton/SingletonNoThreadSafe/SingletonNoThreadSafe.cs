namespace Singleton;

[ClassInterface(ClassInterfaceType.None)]
public sealed class SingletonNoThreadSafe<T> : MarshalByRefObject
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private T? mInstance;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Func<T> mImplementation;

    public SingletonNoThreadSafe(Func<T> implementation)
    {
        ArgumentNullException.ThrowIfNull(implementation);
        mImplementation = implementation;
    }

    public sealed override string ToString() => (mImplementation?.GetType().Name ?? base.ToString());

    public T? Instance => (mInstance ??= mImplementation.Invoke());
}