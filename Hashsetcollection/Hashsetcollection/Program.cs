using System;
using System.Collections.Generic;
public class A
{
    public static void Main(string [] args)
    {
        var names = new HashSet<string>();
        names.Add("vishab");
        names.Add("rishabh");
        names.Add("vishab");
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
