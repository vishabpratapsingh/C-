using System;

    class Program
    {
        public delegate void AnonymousFun();
        static void Main(string[] args)
        {
            AnonymousFun fun = delegate () {
                Console.WriteLine("This is anonymous function");
            };
            fun();
        }
    }
