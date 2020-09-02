using System;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
        int i = 0;
        while ((i = f.ReadByte()) != -1)
        {
            Console.Write((char)i);
        }
        f.Close();
    }
}