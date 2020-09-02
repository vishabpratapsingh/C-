using System;
    class Program
    {
        static void Main(string[] args)
        {
        int sum = 0, no;

            Console.WriteLine("enter any positive number");
        no = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=no;i++)
        {
            Console.Write("+ " + i);
            sum = sum + i;

        }
        Console.WriteLine("\nTotal sum=" + sum);
        Console.ReadKey();

        }
    }
