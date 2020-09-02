using System;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
        f.WriteByte(65);
        f.Close();
    }
}