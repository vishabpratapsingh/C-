using System;
using System.IO;
using System.Text;
public class StringwriterExample
{
    public static void Main(string[] args)
    {
        string Text = "Hello, welcome to jammu \n" +
            "it is a nice place \n" +
            "it is known as city of Temples";
        StringBuilder sb = new StringBuilder();
        StringWriter writer = new StringWriter(sb);
        writer.WriteLine(Text);
        writer.Flush();
        writer.Close();
        StringReader reader = new StringReader(sb.ToString());
        while (reader.Peek() > -1)
        {
            Console.WriteLine(reader.ReadLine());
        }


    }
}