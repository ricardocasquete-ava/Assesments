namespace Singleton;

[ClassInterface(ClassInterfaceType.None)]
public sealed class SingletonThreadSafe<T> : MarshalByRefObject
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private T? mInstance;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly object mSync;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Func<T> mImplementation;

    public SingletonThreadSafe(Func<T> implementation)
    {
        ArgumentNullException.ThrowIfNull(implementation);
        mSync = new object();
        mImplementation = implementation;
    }

    public sealed override string ToString() => (mImplementation?.GetType().Name ?? base.ToString());

    public T? Instance
    {
        get
        {
            if (mInstance is not null) return mInstance;
            lock (mSync) return (mInstance ??= mImplementation.Invoke());
        }
    }
}