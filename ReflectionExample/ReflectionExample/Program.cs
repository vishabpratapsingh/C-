using System;
using System.Reflection;
public class Reflection1
{
    public static void Main(string[] args)
    {
        int a = 10;
        Type type = a.GetType();
        Console.WriteLine(type);
    }
}