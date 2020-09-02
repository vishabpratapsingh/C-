using System;
using System.Threading;
public class Synchronous
{

    public static void Main(string[] args)
    {
        calculate();
        Console.Read();

    }
    public static void calculate()
    {
        calculate1();
        calculate2();
        calculate3();
    }
        static int calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("calculating result1");
            return 1;
        }
        static int calculate2()
        {
            Console.WriteLine("calculating result2");
            return 2;
        }
        static int calculate3()
        {
            Console.WriteLine("calculating result3");
            return 3;
        }
}
  

