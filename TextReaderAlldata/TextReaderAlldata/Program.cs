using System;
using System.IO;
namespace TextReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("e:\\f.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}