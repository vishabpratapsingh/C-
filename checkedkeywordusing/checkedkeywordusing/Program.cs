using System;
class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
