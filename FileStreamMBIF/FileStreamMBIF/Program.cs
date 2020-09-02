using System;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
       
        for (int i = 65; i <= 90; i++)
        {
         Console.WriteLine((byte)i);
        }
        f.Close();
     
    }
}