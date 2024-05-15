namespace Outside;

public class Third
{
    public int thirdPublic = 60;
    internal int thirdInternal = 50;

    protected internal int protectedInternal = 70;
}

public class Four
{
    public void Hello()
    {
        Third three = new Third();
        Console.WriteLine(three.protectedInternal);
    }
}
