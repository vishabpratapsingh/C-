using System;

public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
}
public class Over
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(12, 13));
        Console.WriteLine(Cal.add(12, 13, 14));

    }
}




