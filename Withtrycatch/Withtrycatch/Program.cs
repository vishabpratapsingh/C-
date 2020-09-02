using System;

     public class UncheckedProgram
    {
         public static void Main(string[] args)
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
