using System;
public delegate int calculate(int n);
public class A
{

    static int number = 100;
    public static int add(int n)
    {
        number = number + n;
        return number;
    }
    public static int mul(int n)
    {
        number= number*n;
        return number;
    }
    public static int getnumber()
    {
        return number;
    }
    public static void Main(string[] args)
    {
        calculate c1 = new calculate(add);
        calculate c2 = new calculate(mul);
        c1(20);
        Console.WriteLine("after c1 delegate,number is:" + getnumber());
        c2(3);
        Console.WriteLine("after c2 delegate,number is :" + getnumber());
    }
}