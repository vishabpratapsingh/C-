using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class A
{
    public static void Main(String[] args)
    {
        List<int> listinteger = new List<int>()
        {
            1,2,3,4,5,6,7,8,9
        };
        var MethodSyntax = (from obj in listinteger
                            where obj > 5
                            select obj).Sum();
        Console.WriteLine("sum is:" + MethodSyntax);
        Console.ReadKey();

    }
}