Singleton singleton = Singleton.GetInstance();




public class Singleton
{
    private static Singleton instance = null;
    private string text;
    private Singleton()
    {
        text = "hello world!";
    }
    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();
        return instance;
    }
    public string GetText()
    {
        return text;
    }
}

