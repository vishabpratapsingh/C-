using System;
public class A
{
    public delegate void print(int value);
    public static void Main(string[] args)
    {
        print printdel = printNum;
        printdel(100000);
        printdel(2000);
        printdel = printmoney;
        printdel(100000);
        printdel(2000);
    }
    public static void printNum(int num)
    {

        Console.WriteLine("Number: {0,-12:N0}", num);
    }
    public static void printmoney(int money){
        Console.WriteLine("Money:{0:C}", money);
    }
}