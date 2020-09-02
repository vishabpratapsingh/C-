using System;
using System.Collections.Generic;
public class A
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        names.Add("101", "vishab");
        names.Add("102", "rishabh");
        names.Add("103", "sahil");
    foreach(KeyValuePair<string,string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}


