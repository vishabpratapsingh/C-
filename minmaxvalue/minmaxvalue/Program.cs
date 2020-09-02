using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
          
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           
            int minimumNum = a.Min();
     


            int maximumNum = a.Max();
        

           
            int sum = a.Sum();
            int count = a.Count();



            Console.WriteLine("The minimum Number is {0}", minimumNum);

            Console.WriteLine("The maximum Number is {0}", maximumNum);
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("no of elements is {0}", count);

            Console.ReadLine();
        }
    }
