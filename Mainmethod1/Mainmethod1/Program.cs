using System;
public class A
{
    public static void Main(int args)
    {
        Console.WriteLine("method 1 exceuting: M1");
    }
    public static void Main(char args)
    {
        Console.WriteLine("method 2 exceuting: M2");
    }
    public static void Main(Double[] args)
    {
        Console.WriteLine("method 3 exceuting: M3");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(" original method  exceuting: M");
    }
}