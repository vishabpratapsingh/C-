using System;
using System.Collections.Generic;
public class A
{
    public static void Main(string[] args)
    {
        var names = new List<string>();
        names.Add("vishab");
        names.Add("rishabh");
        names.Add("rohit");
        foreach( var name in names)
        {
            Console.WriteLine(name);
        }
    }
}

