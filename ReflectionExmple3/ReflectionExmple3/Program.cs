using System;
using System.Reflection;
public class Reflection3
{
    public static void Main(string[] args)
    {
        Type a = typeof(System.String);
        Console.WriteLine(a.FullName);
        Console.WriteLine(a.BaseType);
        Console.WriteLine(a.IsClass);
        Console.WriteLine(a.IsEnum);
        Console.WriteLine(a.IsInterface);
    }
}