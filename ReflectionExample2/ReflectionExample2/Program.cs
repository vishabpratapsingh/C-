using System;
using System.Reflection;
public class Reflection2
{
    public static void Main(string[] args)
    {
        Type a = typeof(System.String);
        Console.WriteLine(a.Assembly);
    }
}