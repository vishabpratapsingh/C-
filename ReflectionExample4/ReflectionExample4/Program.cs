using System;
using System.Reflection;
public class ReflectionExample
{
    public static void Main()
    {
        Type t = typeof(System.String);

        Console.WriteLine("Constructors of{0} type..." , t);
        ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        foreach (ConstructorInfo c in ci)
        {
            Console.WriteLine(c);
        }
    }
}
