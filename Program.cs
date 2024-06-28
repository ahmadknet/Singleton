public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly object LockObject = new object();

    private Singleton()
    {
        // Private constructor to prevent external instantiation.
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    public void SomeMethod()
    {
        Console.WriteLine("SomeMethod called.");
    }
}

public class Program
{
    public static void Main() {
        // Usage:
        var singletonInstance = Singleton.Instance;
        singletonInstance.SomeMethod();
    }

}
