using System;
using System.Collections.Generic;
public class A
{
    public static void Main(string[] args)
    {
        var names = new SortedSet<string>();
        names.Add("vishab");
        names.Add("rishabh");
        names.Add("raju");
        names.Add("santosh");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}