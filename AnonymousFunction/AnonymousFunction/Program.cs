using System;
public class Anonymous
{
    public delegate int Square(int num);
    public static void Main(String[] args)
    {
        Square GetSquare = x => x * x;
        int i = GetSquare(5);
        Console.WriteLine("Square:" + i);
    }
}