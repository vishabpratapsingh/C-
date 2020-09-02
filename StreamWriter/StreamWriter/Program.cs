using System;
using System.IO;
public class StreamWriterExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\output.txt", FileMode.Create);
        StreamWriter s = new StreamWriter(f);

        s.WriteLine("hello VISHAB");
        s.Close();
        f.Close();
        Console.WriteLine("File created successfully...");
    }
}