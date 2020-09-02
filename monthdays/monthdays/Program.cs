using System;

    public class A
    {
  

        static void Totalnumberofdays(int n)
        {
            switch (n)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("30");
                    break;
                case 2:
                    Console.Write("28/29");
                    break;
            }
        }



        static public void Main(string[] args)
        {
        int n = 11;
            
                Totalnumberofdays(n);
            


        }
    }



