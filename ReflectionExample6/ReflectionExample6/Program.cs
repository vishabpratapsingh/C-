using System;
using System.Reflection;
public class ReflectionExample
{
    public static void Main()
    {
        Type t = typeof(System.String);

        Console.WriteLine("Fields of {0} type...", t);
        FieldInfo[] ci = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
        foreach (FieldInfo f in ci)
        {
            Console.WriteLine(f);
        }
    }
}
