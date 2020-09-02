using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class A
{
    public static void Main(string[] args)
    {
        List<string> countries = new List<string>();
        countries.Add("India");
        countries.Add("US");
        countries.Add("Australia");
        IEnumerable<string> result = countries.Select(x => x);
        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

    }
}
