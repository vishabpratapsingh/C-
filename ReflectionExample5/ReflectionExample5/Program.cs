using System;
using System.Reflection;
public class ReflectionExample
{
    public static void Main()
    {
        Type t = typeof(System.String);

        Console.WriteLine("Methods of {0} type...", t);
        MethodInfo[] ci = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        foreach (MethodInfo m in ci)
        {
            Console.WriteLine(m);
        }
    }
}