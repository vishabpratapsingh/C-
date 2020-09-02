using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class A
{
    public static void Main( string[] args)
    {
        List<int> integerlist = new List<int>()
        {
            1,2,3,4,5,6,7,8,9
        };
        var QuerySyntax = from obj in integerlist
                           where obj > 6
                           select obj;
        foreach(var item in QuerySyntax)
        {
            Console.WriteLine(item + " ");
        }
        Console.ReadKey();
    }
}